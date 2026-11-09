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

![Login Form](screenshots/login-form.png)

### 2. Choose Form

After the login step, the Choose Form allows the user to select which activity to open:

- **Bicycle Rental** – opens the bicycle rental form.
- **Mushroom Identifier** – opens the mushroom identification form.

The Back buttons on the activity forms return the user to the Choose Form.

**Screenshot:** Save an image as `screenshots/choose-form.png`.

![Choose Form](screenshots/choose-form.png)

### 3. Bicycle Rental Form

The Bicycle Rental Form provides the bicycle rental interface. The user enters or selects the required rental information and the application displays the calculated total amount in the total amount text box.

**Screenshot:** Save an image as `screenshots/bicycle-form.png`.

![Bicycle Rental Form](screenshots/bicycle-form.png)

### 4. Mushroom Identifier Form

The Mushroom Identifier uses a decision tree to identify a mushroom. The user answers the questions by clicking **Yes** or **No**. Based on the answers, the application displays the identified mushroom in a message box and then starts the questions again.

The questions include whether the mushroom has a ring, grows in a forest, has a convex cup, and has gills. The decision tree follows the relevant Yes/No branches and displays one of the configured mushroom results.

**Screenshot:** Save an image as `screenshots/mushroom-form.png`.

![Mushroom Identifier Form](screenshots/mushroom-form.png)

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

```text
Your mushroom is: [Mushroom Name]
```

The mushroom names configured in the decision tree are:

- Agaric Jaunissant
- Amanite tue-mouches
- Cepe de bordeaux
- Coprin chevelu
- Girolle
- Pied bleu

For example:

```text
Title: Result

Your mushroom is: Agaric Jaunissant
```

The actual mushroom name depends on the user's answers.

### Bicycle rental output

After the user provides the rental information and performs the calculation, the calculated total amount is displayed in the form's total amount text box.

**Example output:** `[Insert the actual total amount displayed by your application here.]`

### Login output

- **Successful login:** `[Insert the exact success message or next-screen behavior.]`
- **Unsuccessful login:** `[Insert the exact error message displayed by your application.]`

Replace the bracketed examples with the exact messages and values shown by your running application so that the README matches the actual program.

---

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

## Screenshots

Create a folder named `screenshots` in the same directory as this README file. Capture each form while the application is running, save the images using the filenames shown below, and add them to that folder.

| Screenshot filename | What to capture |
|---|---|
| `login-form.png` | The Login Form |
| `choose-form.png` | The Choose Form showing both activity options |
| `bicycle-form.png` | The Bicycle Rental Form with a sample calculation |
| `mushroom-form.png` | The Mushroom Identifier Form showing a question |
| `mushroom-result.png` | A result message box after answering the questions |

After saving the result screenshot, display it in this README by adding:

```markdown
![Mushroom Result](screenshots/mushroom-result.png)
```

---

## Author

**Ndayishimiye Ineza Giuly**  
**Student ID:** 27390  
**Course:** .NET Programming with C#
"""

path = Path("/mnt/data/README_Lab1.md")
path.write_text(readme, encoding="utf-8")
print(f"Created: {path}")
