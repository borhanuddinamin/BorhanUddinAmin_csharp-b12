// See https://aka.ms/new-console-template for more information
int line = Convert.ToInt32(Console.ReadLine());
string[] str = new string[line];
for (int i = 0; i < line; i++)
{
    str[i] = Console.ReadLine();

}

for (int i = 0; i < str.Length; i++)
{
    char[] chars = str[i].ToCharArray();
    Console.Write(chars[0]);
    Console.Write(chars[1]);
    for (int j = 3; j < chars.Length; j=j+2)
    {

        Console.Write(chars[j]);
    }
    if(i < str.Length-1)
    {
        Console.Write("\n");
    }


}


