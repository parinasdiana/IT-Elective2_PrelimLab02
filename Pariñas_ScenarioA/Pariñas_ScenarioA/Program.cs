using System;

namespace Pariñas_ScenarioA
{
	public abstract class Vehicle
	{
		private string _vehicleID;
		private string _modelName;

		public string VehicleID => _vehicleID;
		public string ModelName => _modelName;

		public Vehicle(string id, string model)
		{
			_vehicleID = id;
			_modelName = model;
		}

		public virtual double CalculateRange()
		{
			return 0;
		}
	}

	public class ElectricBus : Vehicle
	{
		private double _batteryPercentage;

		public double BatteryPercentage
		{
			get => _batteryPercentage;
			set
			{
				// Validation logic inside setter 
				if (value < 0 || value > 100)
					throw new ArgumentException("Battery must be between 0 and 100.");
				_batteryPercentage = value;
			}
		}

		// base() constructor syntax
		public ElectricBus(string id, string model, double battery) : base(id, model)
		{
			BatteryPercentage = battery;
		}

		public override double CalculateRange() // Polymorphism
		{
			// Exception: Throw error if energy level < 5% 
			if (BatteryPercentage < 5)
				throw new InvalidOperationException($"Critical Alert: {ModelName} battery is too low ({BatteryPercentage}%).");

			return BatteryPercentage * 5.5; // Example range logic
		}
	}

	// Sub-Class: GasPoweredVan 
	public class GasPoweredVan : Vehicle
	{
		private double _fuelLevel;

		public double FuelLevel
		{
			get => _fuelLevel;
			set
			{
				if (value < 0) throw new ArgumentException("Fuel level cannot be negative."); 
                _fuelLevel = value;
			}
		}

		public GasPoweredVan(string id, string model, double fuel) : base(id, model)
		{
			FuelLevel = fuel;
		}

		public override double CalculateRange()
		{
			if (FuelLevel < 5)
				throw new InvalidOperationException($"Critical Alert: {ModelName} fuel is too low ({FuelLevel}L).");

			return FuelLevel * 12.0; // Example range logic
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Wrap in try-catch-finally for Robustness
			try
			{
				ElectricBus bus = new ElectricBus("BUS-001", "Volt-Transitor", 4.0);
				Console.WriteLine($"{bus.ModelName} Range: {bus.CalculateRange()} km");
			}

			catch (ArgumentException ex) // Specific catch 
			{
				Console.WriteLine($"Input Error: {ex.Message}");
			}
			catch (Exception ex) // General catch
			{
				Console.WriteLine($"System Error: {ex.Message}");
			}
			finally
			{
				// Mandatory shutdown message
				Console.WriteLine("System Shutdown.");
			}
		}
	}
}