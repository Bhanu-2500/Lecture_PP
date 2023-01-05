// Linq
//This style of programming called functional programming

using ConsoleApp1;

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


var greaterThanTen = numbers.Where(n/*parameter*/ => n> 10/*condition*/);
foreach(var num in greaterThanTen)
{
    Console.WriteLine(num);
}

//since Where return a collection, we can use Sum method also and get the sum of that collection
var sum2 = numbers.Where(n/*parameter*/ => n > 10/*condition*/).Sum();
Console.WriteLine($"Sum of greater than 10 is {sum2}");

var sum3 = numbers.Where(n => n < -200).FirstOrDefault();// this will return first or defalt
Console.WriteLine($"First negative number {sum3}");


var people = DataGenerator.GeneratePeople();
foreach(var person in people)
{
    Console.WriteLine(person);
}

var count = people.Count();
Console.WriteLine($"Count of people {count}");

var tatalExperence = people.Sum(p => p.YearsOfExperience);
Console.WriteLine($"Total Experience of that 10 people {tatalExperence}");

var afterBorn2000 = people.Where(p => p.BirthDay.Year>2000).ToList();
foreach (var p in afterBorn2000)
{
    Console.WriteLine($"Get the people who born after 2000 = {p}");

}
Console.WriteLine("_______________________________________________________");

var p2 = people.OrderBy(p => p.BirthDay);
foreach (var p in p2)
{
    Console.WriteLine($"Get the people sortred = {p}");

}
Console.WriteLine("_______________________________________________________");

var p3 = people.OrderBy(p => p.BirthDay.Year)
               .ThenBy(p=> p.FirstName)
               .ToList(); // We can get seperate from the base line this dot method
//We can use OrderByDescending method and ThenByDescending
foreach (var p in p3)
{
    Console.WriteLine($"Get the people sortred = {p}");
}

Console.WriteLine("___________________________  Grouping  ____________________________");

//Grouping
var groups = people.GroupBy(p => p.BirthDay.Year);
foreach (var group in groups)
{
    foreach (var person in group)
    {
        Console.WriteLine(person);
    };
    Console.WriteLine("--     --");
}
Console.WriteLine("___________________________  ####  ____________________________");
var p4 = people
    .Where(p => p.LastName.StartsWith('B'))
    .Select(p=>
        new {p.FirstName, p.LastName})
    ;

foreach (var p in p4)
{
    Console.WriteLine(p.FirstName);
    Console.WriteLine(p.LastName);
}



