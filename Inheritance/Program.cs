Person[] persons = new Person[3]
{
    new Customer
    {
    FirstName = "Engin"
    },
    new Person
    {
    FirstName = "Ece"
    },
    new Student
    {
    FirstName = "Furkan"
    },
};

foreach (Person person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departman { get; set; }
}
