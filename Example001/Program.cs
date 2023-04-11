void Method1()
{
    // System.Console.WriteLine("Author   ");
}
// Method1();

void Method2(string message){
    System.Console.WriteLine(message);

}
// Method2("Текст сообщения");

void Method21(string message, int count){
    int i = 0;
    while(i < count)
    {
        System.Console.WriteLine(message);
        i++;
    }
}
// Method21(message: "Text", count: 4);
// Method21(count: 4, message: " New Text");

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// System.Console.WriteLine(year);

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = "";
//     while( i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string c)
{
    string result = "";
    for(int i = 0;i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "WWE");
// System.Console.WriteLine(res);

// for (int i = 2; i <= 10; i ++)
// {
//         for (int j = 2; j <= 10; j ++)
//         {
//           System.Console.WriteLine($"{i} * {j} ={i*j}");
//         }
//         System.Console.WriteLine();
// }

string text = "Я помню чудное мгновенье:"
            +"Передо мной явилась ты,"
            +"Как мимолетное виденье,"
            +"Как гений чистой красоты.";   

//  string s = "aasw"
//              0123...
// s[3] // w

string Replace(string text, char oldValue, char NewValue)
{
    string result = "";

    int length = text.Length;
    for(int  i= 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string NewText = Replace(text,' ', '/');
System.Console.WriteLine(NewText);
System.Console.WriteLine();
System.Console.WriteLine(NewText);

NewText = Replace(NewText,'п', 'П');
System.Console.WriteLine(NewText);
System.Console.WriteLine();
System.Console.WriteLine(NewText);

NewText = Replace(NewText,'м', 'М');
System.Console.WriteLine(NewText);
