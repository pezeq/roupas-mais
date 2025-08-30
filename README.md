# Roupas+ - Inventory and Sales Management System

This project is an academic exercise developed during the first semester of a Computer Science program, as part of the **"Programação de Computadores"** course. It was designed to reinforce foundational programming skills—particularly **array manipulation**—before diving into object-oriented programming.

---

## 📚 Project Summary

**Roupas+** is a console-based system built in C# to help a fictional clothing store manage its products and sales. It fulfills a real-world scenario requirement provided by the course instructor.

Key focus: Implement all functionalities using **arrays (matrices)** instead of classes or objects.

---

## 📌 Features

- **Product Registration**
  - Add new products with: product code, description, price, and quantity.
- **Sales Processing**
  - Register a sale with product code, employee code, and quantity sold.
  - Automatically updates the stock after a sale.
- **Sales Reports**
  - Shows all sales including employee and product info.
  - Displays total sales value.
- **Employee Sales Reports**
  - Shows sales grouped by employee.
  - Includes total and 10% commission calculation.
- **Inventory Check**
  - Displays current stock levels.
- **Product Update**
  - Update product description, price, or increase stock.
- **Product Deletion**
  - Remove a product by shifting all elements in the array.

---

## 📋 Data Structures Used

Two 2D arrays were used to simulate relational tables:

### Products Table
| Index | Description        |
|-------|--------------------|
| 0     | Product Code       |
| 1     | Product Description|
| 2     | Price              |
| 3     | Quantity in Stock  |

### Sales Table
| Index | Description        |
|-------|--------------------|
| 0     | Product Code       |
| 1     | Employee Code      |
| 2     | Quantity Sold      |
| 3     | Total Sale Value   |

---

## 💻 Technologies

- **Language**: C#
- **Platform**: .NET Console Application
- **Concepts**:
  - 2D arrays (matrices)
  - Looping and conditionals
  - Input validation
  - Menu navigation
  - Basic reporting and formatting

---

## 📁 Project Structure

The entire logic resides in a single file: `Program.cs` (see `review.txt` for the full code).
It uses static helper methods for each menu operation and input validation.

---

## 🧠 Learning Outcomes

- How to manipulate **2D arrays** to store structured data.
- Practice with **procedural programming** concepts.
- How to simulate CRUD operations without using objects.
- Importance of input validation and separation of concerns (via methods).

---

## 📎 Academic Context

- **Course**: Programação de Computadores
- **Professor**: Lucas Schmidt
- **Semester**: 1st
- **University**: [Your University Name]
- **Grade**: 10 points total

---

## 👨‍💻 Author

Pedro Ezequiel  
GitHub: [@pezeq](https://github.com/pezeq)

---
**Note**: This project was intentionally implemented without OOP principles to strengthen core logic and data structure handling.