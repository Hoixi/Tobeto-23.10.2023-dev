string[] students = new string[3] { "Engin", "Demir", "Salih" };
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

string[] students2 = { "Engin", "Demir", "Salih" };

foreach (string student in students2)
{
    Console.WriteLine(student);
}