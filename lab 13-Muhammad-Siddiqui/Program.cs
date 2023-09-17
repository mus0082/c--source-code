// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Text.Json;


namespace Lab6;
class Program
{
    static void Main(string[] args)

    {
        int option = 0;
        List<Person> people = new List<Person>();
        Person person = new Person();

        do
        {
            option = displayMenu();
            if (option == 1)
            {

                Person p = new Person();

                Console.WriteLine("Enter a first name");
                p.FirstName = Console.ReadLine();

                Console.WriteLine("Enter a last name");
                p.LastName = Console.ReadLine();

                Console.WriteLine("Enter a Birthdate");
                p.BirthDate = Console.ReadLine();

                Console.WriteLine("Enter a Address");
                p.Address = Console.ReadLine();

                Console.WriteLine("Enter a City");
                p.City = Console.ReadLine();

                Console.WriteLine("Enter a Country");
                p.Country = Console.ReadLine();

                Console.WriteLine("Enter a Province");
                p.Province = Console.ReadLine();
                people.Add(p);
            }
            if (option == 2)
            {
                list(people);
            }
            if (option == 3)
            {
                person.forSavingPeople(people);
            }
            if (option == 4)
            {
                person.forLoadingPeople(people);
            }

        } while (option != 5);
    }

    public static void list(List<Person> people)
    {
        foreach (var p in people)
        {
            p.forListingPeople();
        }
        Console.ReadLine();
    }
    public static int displayMenu()
    {
        Console.WriteLine("1. Add Person");
        Console.WriteLine("2. List People");
        Console.WriteLine("3. Save List");
        Console.WriteLine("4. Load List");
        Console.WriteLine("5. Exit");
        return int.Parse(Console.ReadLine());
    }
}

















































































































