# Adapter Pattern

## Overview

This project demonstrates the Adapter Design Pattern in C#. The Adapter Pattern is a structural design pattern that allows objects with incompatible interfaces to work together. In this example, we create a unified interface for driving different types of vehicles (`Vehicle`) and use an adapter (`BicycleAdapter`) to integrate a `Bicycle` class into this interface.

## Purpose

The purpose of this project is to showcase how the Adapter Pattern can be used to adapt a class with an incompatible interface (`Bicycle`) so that it can be used where a different interface (`Vehicle`) is expected.

## Features

- **Unified Interface**: Provides a common interface (`Vehicle`) for different vehicle types.
- **Adapter Implementation**: `BicycleAdapter` class adapts `Bicycle` to be compatible with `Vehicle`.
- **Testing**: Includes unit tests to verify the correct functionality of the adapter and the `Car` class.

## Design

### Classes and Interfaces

1. **`Vehicle`**: The target interface with a method `Drive()`.
2. **`Car`**: Implements `Vehicle` and provides its own `Drive()` method.
3. **`Bicycle`**: Has a `Pedal()` method, which is incompatible with `Vehicle`.
4. **`BicycleAdapter`**: Adapts `Bicycle` to `Vehicle` by implementing the `Drive()` method and calling `Pedal()`.

### Diagram
![Class Diagram](https://github.com/shivam5445/AdapterPattern/blob/master/Class.png)

