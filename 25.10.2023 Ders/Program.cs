int term = 10;
string information = "İhtiyaç Kredisi";
char firstLetter = 'A';

Console.WriteLine(information[0]);
Console.WriteLine(information[1]);
Console.WriteLine(information[2]);
Console.WriteLine(information[3]);
Console.WriteLine(information[4]);
Console.WriteLine(information[5]);

double dolarToday = 27.40;
double dolarYesterday = 27.50;

if(dolarToday < dolarYesterday)
{
    Console.WriteLine("DOWN");
}
else if(dolarToday > dolarYesterday)
{
    Console.WriteLine("UP");
}
else
{
    Console.WriteLine("EQUAL");
}

string button1 = "<button>Giriş yap</button>";
string button2 = "<button>Çıkış yap</button>";

bool isLoggedIn = false;

if (isLoggedIn)
{
    Console.WriteLine(button2);
}
else
{
    Console.WriteLine(button1);
}

string[] courses = new string[] { "C#", "Java", "C++", "Python","JavaScript","Perl" };

Console.WriteLine("<ul>");
foreach (string course in courses)
{
    Console.WriteLine("<li>{0}</li>",course);
}
Console.WriteLine("</ul>");



Console.WriteLine("<ul>");
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine("<li>{0}</li>", courses[i]);
}
Console.WriteLine("</ul>");