// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();
String str1= Console.ReadLine();
char[] ch = new char[str.Length];
int m = 0;


foreach (char c in str)
{
    ch[m] = c;
    m++;
}




int n = 0;

foreach (char c in str1)
{
    if (ch[n] == '0' && c == '1')
    {
        Console.Write("1");
    }
    else if (ch[n] == '1' && c == '0')
    {
        Console.Write("1");

    }
    else if (ch[n] == '1' && c == '1')
    {
        Console.Write("0");

    }
    else if (ch[n] == '0' && c == '0')
    {
        Console.Write("0");
    }
    n++;
}






    




