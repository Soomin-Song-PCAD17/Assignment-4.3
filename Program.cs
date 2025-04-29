using Assignment_4._3;

// Assignment 4.3.1
var jamesBill=new ElectricityBill(1001, "James", 410);
jamesBill.DisplayCalculation();
Console.WriteLine();

// Assignment 4.3.2
var elements432 = new ElementCounter([1,5,1,1,1]);
ElementCounter.DisplayCount(elements432.Count());
Console.WriteLine();

// Assignment 4.3.3
var elements433 = new ElementCounter([1,5,1,1,1]);
elements433.UniqueElements();
Console.WriteLine();
