using System.Collections;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using String = System.String;

namespace test.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet(Name = "ali")]
    public List<Person> ali(int pass)
    {
        Person person = new Person() { name = "ali", family = "sarang" };
        Person person1 = new Person() { name = "ali", family = "sarang" };
        Person person2 = new Person() { name = "ali", family = "sarang" };
        Person person3 = new Person() { name = "ali", family = "sarang" };
        List<Person> persons = new List<Person>();
        persons.Add(person);
        persons.Add(person1);
        persons.Add(person2);
        persons.Add(person3);

        return persons;
    }
    
    public class Person
    {
        public String name { get; set; }
        public String family { get; set; }
    }
}