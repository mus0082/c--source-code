using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;


namespace week_11.Pages;

public class personModel : PageModel
{
    private readonly ILogger<personModel> _logger;

    public personModel(ILogger<personModel> logger)
    {
        _logger = logger;
    }
    public Person inputPerson = new Person();
    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        List<Person> people = Person.LoadPeople();

        if (people == null)
        {
            people = new List<Person>();
        }
        inputPerson.FirstName = Request.Form["inputPerson.FirstName"];
        inputPerson.LastName = Request.Form["inputPerson.LastName"];
        inputPerson.BirthDate = Request.Form["inputPerson.BirthDate"];
        inputPerson.Address = Request.Form["inputPerson.Address"];
        inputPerson.City = Request.Form["inputPerson.City"];
        inputPerson.Country = Request.Form["inputPerson.Country"];
        inputPerson.Province = Request.Form["inputPerson.Province"];

        people.Add(inputPerson);
        Person.SavePeople(people);
        return RedirectToPage("/PersonList");
    }
}