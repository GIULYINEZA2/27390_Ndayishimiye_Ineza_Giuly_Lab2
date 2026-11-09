# Bicycle Rental and Mashroom Guessing App

A C# .NET Windows Forms application developed for the **.NET Programming with C#** course. The project demonstrates a multi-form desktop application with a login screen, a menu for choosing an activity, a bicycle rental form, and a mushroom identification form.

> **Student:** Ndayishimiye Ineza Giuly  
> **Student ID:** 27390  
> **Course:** .NET  


---

## Table of Contents

- [Project Overview](#project-overview)
- [Application Forms](#application-forms)
- [Features](#features)
- [Messages and Expected Outputs](#messages-and-expected-outputs)
- [Technologies Used](#technologies-used)
- [Requirements](#requirements)
- [How to Run the Application](#how-to-run-the-application)
- [Project Structure](#project-structure)
- [Screenshots](#screenshots)

---

## Project Overview

This project is a Windows desktop application built using C# and Windows Forms. It contains four main forms that allow a user to log in, choose an activity, calculate a bicycle rental amount, or identify a mushroom by answering a series of questions.

The application uses Windows Forms controls and event handlers to respond to user actions and display results.

## Application Forms

### 1. Login Form

The Login Form is the entry point of the application. It provides the interface for the user to enter the required login details and proceed to the next form.

**Screenshot:** Save an image as `screenshots/login-form.png`.

<img width="796" height="482" alt="lab 2 login form " src="https://github.com/user-attachments/assets/5456229b-3c69-486b-a4ac-b8f5af932875" />


### 2. Choose Form

After the login step, the Choose Form allows the user to select which activity to open:

- **Bicycle Rental** – opens the bicycle rental form.
- **Mushroom Identifier** – opens the mushroom identification form.

The Back buttons on the activity forms return the user to the Choose Form.

**Screenshot:** Save an image as `screenshots/choose-form.png`.

<img width="796" height="482" alt="lab 2 choose form" src="https://github.com/user-attachments/assets/7bd7a6bb-c138-412c-ac59-c15b303718fa" />


### 3. Bicycle Rental Form

The Bicycle Rental Form provides the bicycle rental interface. The user enters or selects the required rental information and the application displays the calculated total amount in the total amount text box.

**Screenshot:** Save an image as `screenshots/bicycle-form.png`.

<img width="822" height="551" alt="lab 2 bicycle form" src="https://github.com/user-attachments/assets/a37ea244-cce2-4521-aaa4-2c89300bfbb4" />


### 4. Mushroom Identifier Form

The Mushroom Identifier uses a decision tree to identify a mushroom. The user answers the questions by clicking **Yes** or **No**. Based on the answers, the application displays the identified mushroom in a message box and then starts the questions again.

The questions include whether the mushroom has a ring, grows in a forest, has a convex cup, and has gills. The decision tree follows the relevant Yes/No branches and displays one of the configured mushroom results.

**Screenshot:** Save an image as `screenshots/mushroom-form.png`.

<img width="752" height="530" alt="lab 2 mushroom form" src="https://github.com/user-attachments/assets/87515956-3651-405b-87e6-e3114d4683fe" />


---

## Features

- Login screen as the application entry point.
- Navigation from the Choose Form to either activity.
- Back navigation from the activity forms to the Choose Form.
- Bicycle rental amount calculation and display.
- Mushroom identification using a Yes/No decision tree.
- Message box display for the mushroom identification result.
- Windows Forms event handling for buttons and user interactions.

## Messages and Expected Outputs

### Mushroom identification result

When the user answers the questions and reaches a result, the application displays a message box titled **Result** with a message in this format:


The mushroom names configured in the decision tree are:

- Agaric Jaunissant
- Amanite tue-mouches
- Cepe de bordeaux
- Coprin chevelu
- Girolle
- Pied bleu

For example:

The actual mushroom name depends on the user's answers.
<img width="746" height="527" alt="lab 2 mashroom form guessing the mushroom" src="https://github.com/user-attachments/assets/ca76cf56-301c-4715-a2e0-0d0f6cb5169c" />


### Bicycle rental output

After the user provides the rental information and performs the calculation, the calculated total amount is displayed in the form's total amount text box.

**Example output:** <img width="820" height="561" alt="lab 2 bicycle form calculating" src="https://github.com/user-attachments/assets/560f6103-c943-4d90-96db-deb3e4f8ccdb" />




## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET
- **User Interface:** Windows Forms
- **IDE:** Visual Studio
- **Version Control:** Git and GitHub

## Requirements

- Windows operating system.
- Visual Studio with the .NET desktop development workload installed.
- A .NET SDK/runtime compatible with the target framework specified in `Lab1.csproj`.

## How to Run the Application

1. Clone or download this repository.
2. Open `Lab1.slnx` in Visual Studio.
3. Allow Visual Studio to load the project.
4. If prompted, restore the project dependencies.
5. Build the solution using **Build → Build Solution**.
6. Run the application by pressing **F5** or selecting **Start**.

## Project Structure

```text
Lab1/
├── Program.cs
├── Lab1.csproj
├── Lab1.slnx
├── LoginForm.cs
├── LoginForm.Designer.cs
├── LoginForm.resx
├── ChooseForm.cs
├── ChooseForm.Designer.cs
├── ChooseForm.resx
├── BicycleForm.cs
├── BicycleForm.Designer.cs
├── BicycleForm.resx
├── MushroomForm.cs
├── MushroomForm.Designer.cs
├── MushroomForm.resx
├── screenshots/
│   ├── login-form.png
│   ├── choose-form.png
│   ├── bicycle-form.png
│   ├── mushroom-form.png
│   └── mushroom-result.png
└── .gitignore
```


## Author

**Ndayishimiye Ineza Giuly**  
**Student ID:** 27390  
**Course:** .NET
