using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DataGenerator //in static we do not need to create objects,and also we call call methods without creating objects
    {
        static public List<Person> GeneratePeople() {
            var list =new List<Person>
            {
                 new Person { Id = 1, FirstName = "Tom1", LastName = "Brown1", YearsOfExperience = 10, BirthDay = new DateOnly(2000, 10, 05) },
                new Person { Id = 2, FirstName = "Tom2", LastName = "Brown2", YearsOfExperience = 22, BirthDay = new DateOnly(2001, 10, 05) },
                new Person { Id = 3, FirstName = "Tom3", LastName = "Brown3", YearsOfExperience = 43, BirthDay = new DateOnly(2014, 10, 05) },
                new Person { Id = 4, FirstName = "Tom4", LastName = "Brown4", YearsOfExperience = 12, BirthDay = new DateOnly(2015, 10, 05) },
                new Person { Id = 5, FirstName = "Tom5", LastName = "Brown5", YearsOfExperience = 12, BirthDay = new DateOnly(2012, 10, 05) },
                new Person { Id = 6, FirstName = "Tom6", LastName = "Brown6", YearsOfExperience = 22, BirthDay = new DateOnly(2016, 10, 05) },
                new Person { Id = 7, FirstName = "Tom7", LastName = "Brown7", YearsOfExperience = 22, BirthDay = new DateOnly(2008, 10, 05) },
                new Person { Id = 8, FirstName = "Tom8", LastName = "Brown8", YearsOfExperience = 22, BirthDay = new DateOnly(2009, 10, 05) },
                new Person { Id = 9,FirstName = "Tom9", LastName = "Brown9", YearsOfExperience = 22, BirthDay = new DateOnly(2014, 10, 05) },
                new Person { Id = 10,FirstName = "Tom10", LastName = "Brown10", YearsOfExperience = 22, BirthDay = new DateOnly(2013, 10, 05) },

            };
            return list;
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsOfExperience { get; set; }
        public DateOnly BirthDay { get; set; }


        //Defalut console.write line cannot print this object
        //Therefore we override Tostring method and fix that can print this object
        public override string ToString()
        {
            var str = $"{Id} {FirstName} {LastName} {BirthDay} {YearsOfExperience}";
            return str ;
            //Or we can use directly
            //return$"{Id} {FirstName} {LastName} {BirthDay} {YearsOfExperience}";

        }

    }
}
