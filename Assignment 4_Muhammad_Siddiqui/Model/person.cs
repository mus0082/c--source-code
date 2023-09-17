using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Person
{


    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public static void SavePeople(List<Person> people)
    {
        string forJasonData = JsonSerializer.Serialize(people);
        File.WriteAllText("People.json", forJasonData);
        Console.WriteLine("saved successfully.");
    }

    public static List<Person> LoadPeople()
    {

        if (File.Exists("People.json"))
        {
            string forInsideLoadingJason = File.ReadAllText("People.json");
            List<Person> loadedPeople = JsonSerializer.Deserialize<List<Person>>(forInsideLoadingJason);
            Console.WriteLine("Data loaded successfully!");
            return loadedPeople;
        }
        else
        {
            Console.WriteLine("File not found.");
            return new List<Person>();
        }


    }
}