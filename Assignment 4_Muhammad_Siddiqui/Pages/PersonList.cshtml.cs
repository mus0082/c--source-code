using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace week_11.Pages;

public class personListModel : PageModel
{
    private readonly ILogger<personListModel> _logger;

    public personListModel(ILogger<personListModel> logger)
    {
        _logger = logger;
    }

    public List<Person> People = new List<Person>();

    public void OnGet(Person person)
    {
        People = Person.LoadPeople();
    }

}