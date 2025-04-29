using Assignment_4._3;

/// Assignment 4.3.1
/// Write a program in C# Sharp to calculate and print
/// the Electricity bill of a given customer. The
/// customer id., name and unit consumed by the user
/// should be taken from the keyboard and display the
/// total amount to pay to the customer. The charge
/// are as follows: (you may change the charge sheet values)
/// 
/// 0~199: @1.20
/// 200~400: @1.50
/// 400~600: @1.80
/// 600~ : @2.00
/// If bill exceeds $ 400 then a surcharge of 15% will be charged.

var jamesBill =new ElectricityBill(1001, "James", 800);
jamesBill.DisplayCalculation();
Console.WriteLine();

/// Assignment 4.3.2
/// 2. Write a program in C# Sharp to count the frequency
/// of each element of an array. 

var elements432 = new ElementCounter([1,5,1,1,1]);
ElementCounter.DisplayCount(elements432.Count());
Console.WriteLine();

/// Assignment 4.3.3
/// 3. Write a program in C# Sharp to print
/// all unique elements in an array.

var elements433 = new ElementCounter([1,5,1,1,1]);
elements433.UniqueElements();
Console.WriteLine();
