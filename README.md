# Green-Transit Fleet Manager
### Prelim Activity 02: Advanced Object-Oriented Programming and Robustness

## 📌 Project Overview
This project transitions from basic scripting to **Systems Design** by implementing a vehicle fleet management system. It demonstrates the core pillars of Object-Oriented Programming (OOP) to create a structured hierarchy of objects that communicate securely.

## 🛠 Features (Scenario A)
* **Base Class Hierarchy**: Implements a `Vehicle` base class to manage shared properties like `VehicleID` and `ModelName`.
* **Specialized Sub-Classes**: 
    * `ElectricBus`: Manages specific data for battery percentage.
    * `GasPoweredVan`: Manages specific data for fuel levels.
* **Encapsulation**: Protects sensitive data using private fields and public properties with validation logic to ensure data integrity.
* **Polymorphism**: Uses method overriding (`virtual`/`override`) to allow different vehicles to calculate their range uniquely via the `CalculateRange()` method.
* **Robustness**: Employs `try-catch-finally` blocks to handle low energy levels (below 5%) and prevent application crashes.

## 🏗 Learning Objectives Achieved
* **Architected Hierarchies**: Designed a class hierarchy using Inheritance to reduce code redundancy.
* **Enforced Encapsulation**: Protected data using Private Fields and Public Properties.
* **Implemented Polymorphism**: Used Method Overriding to allow unique object responses to the same command.
* **Ensured Robustness**: Used error handling to manage runtime exceptions and ensure a clean system shutdown.

## 💻 Tech Stack
* **Language**: C# 
* **Type**: Console Application 
* **Design**: UML Class Diagramming 

---
*Developed as part of the Advanced OOP and Robustness Lab Module.* 
