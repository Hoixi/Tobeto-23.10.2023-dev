PersonManager manager = new PersonManager();
Customer customer = new Customer
{
    FirstName = "Furkan",
    LastName = "Kayali",
    Address = "İstanbul",
    Id = 1
};

Student student = new Student
{
    FirstName = "Ece",
    LastName = "Kayali",
    Departmant = "Computer Sc.",
    Id = 1
};
manager.Add(student);
manager.Add(customer);

interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}