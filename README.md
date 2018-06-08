# Lab02-UnitTesting
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
A console application that simulates the function of an Automated Teller Machine (ATM).

## Getting Started
1. Create a fork of this repository, and clone your fork to your device.  
2. Open the solution file (UnitTesting.sln) in Visual Studio.
3. To run the app, click the green arrow button labeled "Start".
4. For testing, navigate to the BankTest project using the Solution Explorer.
5. To run the tests, press CTRL+R or navigate to Tests > Run > All Tests in the top-level menu.

## Using The Application
![screenshot](https://github.com/btaylor93/Lab02-UnitTesting/raw/master/assets/screenshot.jpg)
1. When you start the application, a console window like the one seen above will open. You will be asked to enter a number between one and three into the terminal to select one of the transaction options.
2. If you choose to add or remove funds from the account (which has $5000 in it when you start the application), you will then be asked to enter an amount of money to be added or removed. (Note that you cannot remove more money than is already in the account.)
3. After your transaction has finished, you will be asked if you would like to make another transaction. The application continues running until the user enters "N" at this prompt, or until the console window is closed.

## Architecture
**Languages Used**: C#  

Written with Visual Studio Community 2017.

## Change Log
06-06-2018 12:29pm - Initial version.
