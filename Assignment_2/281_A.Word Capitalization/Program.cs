// See https://aka.ms/new-console-template for more information

string str  = Console.ReadLine();
char[]  ch = str.ToCharArray();


if (char.IsUpper(ch[0]))
{
    foreach(char c in ch)
    {
        Console.Write(c);
    }
}
else
{
    Console.Write(Char.ToUpper(ch[0]));

    for(int i =1; i < ch.Length; i++)
    {
        Console.Write(ch[i]);
    }
}
