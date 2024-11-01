# C# Technical Test 🚀

## Description
This repository is part of a **C# technical test** featuring **three separate projects**, each addressing distinct challenges. Below is a guide to navigate through the projects:

- [🚗 Parking Lot Calculator 🚌](#-parking-lot-calculator-)
- [📐 Geometric Figures 🧮](#-geometric-figures-)

---

# 🚗 Parking Lot Calculator 🚌

## 🔍 Overview
The **Parking Lot Calculator** project is designed to solve various challenges related to parking space management. Starting with **Challenge 1**, this project aims to determine the minimum number of slots needed to accommodate different types of vehicles and slot types.

## 🧩 Challenges

### Challenge 1: Calculate Minimum Occupied Slots
> Imagine you are managing a parking lot with two types of slots: big and small.  
> - **Big slots** can either park one **bus** or fit **3 cars**.  
> - **Small slots** can only fit **one car**.

Create a function that calculates the **minimum number of slots occupied** by the buses and cars, based on the number of big slots, small slots, buses, and cars provided.

### 📥 Example Input and Output:
Input:
```
Big slots: 6
Small slots: 5
Buses: 4
Cars: 3
```
Expected Output:
```
Minimum slots occupied: 5
Big slots occupied by buses: 4
Big slots occupied by cars: 1
Small slots occupied by cars: 0
Big slots free: 1
Small slots free: 5
Buses not parked: 0
Cars not parked: 0
```

---

# 📐 Geometric Figures 🧮

## 🔍 Overview
This project features a hierarchy of classes modeling geometric shapes, including **triangles**, **rectangles**, and **circles**. Each figure calculates its perimeter and area and has methods to draw itself on different types of canvases.

## 🧩 Challenges

### Challenge 2: Geometric Figures
- **Geometric Figures**:
  - Classes representing triangles, rectangles, and circles.

- **Canvas Types**:
  - Two types of canvases that can draw these figures:
    - **BitmapCanvas**: Draws on a bitmap.
    - **ExportCanvas**: Writes the figure data to a text file.

### 📥 Example Input and Output:
**Input:**
```
Triangle: First side: 6 Second side: 6 Third side: 6
Rectangle: Width: 6 Height: 8
Circle: Radius: 12
```
Expected Output:
```
Triangle: Perimeter: 18, Area: 15.588457268119896
Rectangle: Perimeter: 28, Area: 48
Circle: Perimeter: 75.39822368615503, Area: 452.3893421169302
```

---
