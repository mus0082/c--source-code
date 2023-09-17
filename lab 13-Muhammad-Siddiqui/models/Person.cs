using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Person
{
    public string FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }


    public void forListingPeople()
    {

        Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.BirthDate + " " + this.Address + " " + this.City + " " + this.Country + " " + this.Province);

    }
    public void forSavingPeople(List<Person> people)
    {

        string forJasonData = JsonSerializer.Serialize(people);
        File.WriteAllText("storePersons.json", forJasonData);
        Console.WriteLine("saved successfully.");
    }


    public void forLoadingPeople(List<Person> people)
    {
        if (File.Exists("storePersons.json"))
        {
            string forInsideLoadingJason = File.ReadAllText("storePersons.json");
            JsonSerializer.Deserialize<List<Person>>(forInsideLoadingJason);

            Console.WriteLine("Data loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }
}
