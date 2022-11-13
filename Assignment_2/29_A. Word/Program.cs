// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();
char[] ch= new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
    ch[i] = str[i];
   
}

int upper = 0;
int lower = 0;
for (int i = 0; i < ch.Length; i++)
{
    if (char.IsUpper(ch[i])){
        upper +=1;
    }
    else
    {
        lower +=1;
    }
}



if (lower == upper)
{
    Console.WriteLine(str.ToLower());
}else if (lower > upper)
{
    Console.WriteLine(str.ToLower());

}else if (lower < upper)
{
    Console.WriteLine(str.ToUpper());
}
