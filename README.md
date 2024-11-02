# C# Technical Test 🚀

## Description
This repository is part of a **C# technical test** featuring **three separate projects**, each addressing distinct challenges.

- [🚗 Parking Lot Calculator 🚌](#-parking-lot-calculator-)
- [📐 Geometric Figures 🧮](#-geometric-figures-)
- [🛠️ Code Refactoring 🛠️](#%EF%B8%8F-code-refactoring-%EF%B8%8F)

---

# 🚗 Parking Lot Calculator 🚌

## 🔍 Overview
This project aims to determine the minimum number of slots needed to accommodate different types of vehicles and slot types.

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

# 🛠️ Code Refactoring 🛠️

## 🔍 Overview
The **Code Refactoring** challenge involves revising existing code to improve its structure, readability, and performance while ensuring it functions as intended.

## 🧩 Challenges

### Challenge 3: Code Refactoring
The goal of this challenge is to refactor the following code to enhance its readability and performance.

### Original Code to Refactor:
```
void foo ( double a, double b, out double r0, out double r1)
{
    int n = (int)Math.Floor(a / b) + 1 ;
    int m = 0 ;

    while ( n > 0 )
    {
        m ++ ;
        n -- ;
    }

    double[] l = new double[m];
    for ( int i = 0 ; i <= m ; ++ i )
        l[i] = (double)i * a * b ;

    double s = -1 ;

    for ( int i = 0 ; i <= m ; ++ i )
        s += l[i] ;

    double average = s / (double)m ;

    r0 = s ;
    r1 = average ;
}
```

### 🛠️ Summary of Required Changes:
1. ✂️ Eliminate the redundant variable `m` and the `while` loop, as `numberOfElements` can be calculated directly.
2. 🗑️ Remove the creation of the array `l`, as it is unnecessary for calculating the total sum.
3. ⚠️ Correct the loop boundaries to avoid out-of-bounds errors.
4. 📊 Ensure that the sum and average calculations are clear and efficient.
