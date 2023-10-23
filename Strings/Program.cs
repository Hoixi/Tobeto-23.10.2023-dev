static void Intro()
{
    string City = "Ankara";
    //Console.WriteLine(City[0]);

    foreach (var item in City)
    {
        Console.WriteLine(item);
    }

    string City2 = "İstanbul";

    Console.WriteLine(String.Format("{0} {1}", City, City2));
}

string sentence = "My name is Furkan Kayali";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Engin Demiroğ";

bool result3 = sentence.EndsWith("i");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0,"Hello, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");
var result13 = sentence.Remove(2,4);

Console.WriteLine(result12);