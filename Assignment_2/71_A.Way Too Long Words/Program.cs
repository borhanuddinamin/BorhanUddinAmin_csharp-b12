// See https://aka.ms/new-console-template for more information
var  read = Convert.ToInt32(Console.ReadLine());
string[] str=new string[read];
for (int i=0; i < read; i++)
{
    str[i] = Console.ReadLine();
}

foreach (string str2 in str)
{

    int re = str2.Length - 1;

    if (str2.Length <= 10)
    {
        Console.WriteLine(str2);
    }else 
    {
        Console.WriteLine($"{str2[0]}{str2.Length - 2}{str2[re]}");
    }



}

