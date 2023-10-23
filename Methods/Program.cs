static void Add()
{
    Console.WriteLine("Added!!!");
}

static int Add2(int number1 = 20, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}

Add();
Add();
Add();
Add();
var result = Add2();
Console.WriteLine(result);