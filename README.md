# Dice Simulator
<br>
![Dice Simulation](https://imgur.com/vDSq3Xm.jpg)

A C# Windows Forms application built in VS Code that simulates rolling two six-sided dice over user-defined frequencies. It leverages asynchronous threading and object-oriented `Die` classes to instantly calculate roll analytics (faces, counts, percentages) while dynamically updating visual dice graphics on the user interface.
<br>

## 🚀 Features

* **Dynamic Simulation:** Simulates an arbitrary number of dice rolls based on user input.
* **Real-Time Data Analytics:** Computes and lists precise frequency counts and percentages for each face.
* **Interactive UI:** Leverages multiple Windows Forms, custom menus, and radio-button inputs.
* **Visual Representation:** Dynamically updates graphical dice face images on the frontend after each roll.
* **Asynchronous Processing:** Uses robust task management to handle computations seamlessly.
<br>

## 🛠️ Tech Stack

* **Language:** C#
* **Framework:** .NET / Windows Forms
* **IDE:** Visual Studio Code
* **Core Libraries:** `System.Collections.Generic`, `System.Threading.Tasks`
<br>

## 📸 User Interface

### 1. Main Dashboard & Configuration
The main window includes a dedicated **File** and **Help** menu bar, input selectors, and application control actions.
<br>
<br>
![Dice Simulation](https://i.imgur.com/917Kc7N.jpg)

* **Input Selection:** Choose the number of simulation rolls using one of 5 distinct radio buttons.
* **Control Actions:** Quickly trigger actions using the **Roll**, **Clear Form**, **Print Form**, or **Quit Program** buttons.
<br>

### 2. Live Simulation & Analytical Output
Once executed, the application updates the visual dice graphics and prints an analytical breakdown to the results console.
<br>

![Dice Simulation](https://imgur.com/vDSq3Xm.jpg)

* **Visual Feedback:** A pair of dice graphics change faces in real-time to match the physical simulation results.
* **Data Breakdown:** Generates a structured textual output mapping **Faces**, **Frequencies**, and **Percentages** rolled.
<br>

## 🧱 Core Architecture

The project adheres to clean Object-Oriented Programming (OOP) principles:
* **`Die` Class:** Encapsulates the state and behavior of an individual six-sided die, generating random values using secure distribution algorithms.
* **Collections Framework:** Organizes and aggregates simulation datasets efficiently.
* **Threading Framework:** Offloads simulation calculations to background tasks, keeping the Windows Forms UI smooth and responsive.
<br>

## ⚙️ Getting Started
### Prerequisites
* [.NET SDK](https://microsoft.com) (Version 6.0 or higher recommended)
* [Visual Studio Code](https://visualstudio.com)
* [C# Extension for VS Code](https://visualstudio.com)

### Installation & Execution
1. **Clone the repository:**
   ```bash
   git clone https://github.com
   cd dice-simulator
   ```
2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```
3. **Run the application:**
   ```bash
   dotnet run
   ```
## 📜 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file
<br>
