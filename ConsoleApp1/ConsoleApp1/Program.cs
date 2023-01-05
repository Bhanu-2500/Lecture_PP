// Linq
//This style of programming called functional programming

List<int> numbers = new List<int> { 10, 4, 55, -3, 0, -34, 1, 22, 2, 45, 3, 21 };

var sum = numbers.Sum();
var max = numbers.Max();
var min = numbers.Min();
var avg = numbers.Average();
var last = numbers.Last();


Console.WriteLine($"Sum is {sum}");
Console.WriteLine($"Max is {max}");
Console.WriteLine($"Min is {min}");
Console.WriteLine($"Avarage is {avg}");
Console.WriteLine($"Last is {last}");


//In This "select" method we can pass a function(Type of annonymus Function)
//Select method return True or False
//Using Where we can filter numbers, and it returns that number


var evenNumbers = numbers.Where(n/*parameter*/ => n%2== 0/*condition*/);
foreach(var num in evenNumbers)
{
    Console.WriteLine(num);
}