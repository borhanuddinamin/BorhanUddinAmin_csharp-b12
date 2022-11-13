// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine(); 
string str2 = Console.ReadLine();

if (str.ToLower() == str2.ToLower())
{
    Console.WriteLine("0");
}else if (str.CompareTo(str2)==-1)
{
    Console.WriteLine(str.CompareTo(str2));
}else if (str.CompareTo(str2) == 1)
{
    Console.WriteLine(str.CompareTo(str2));
}


Console.WriteLine();

