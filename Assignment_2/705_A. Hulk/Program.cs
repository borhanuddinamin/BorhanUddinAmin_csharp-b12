// See https://aka.ms/new-console-template for more information
int i= Convert.ToInt32(Console.ReadLine());


string str1= "I love it ";
string str2= "I hate it ";
string str3 = "that ";



string[] str = new string[100];
//str[0] = "I hate ";
//str[1] = "I love ";
for (int l=0; l<100; l++)
{
    if (l % 2 == 0)
    {
        str[l] = "I hate ";

    }
    else
    {
        str[l] = "I love ";
    }
}



if (i % 2 == 0)
    {
    for (int k = 0; k < i - 1; k++)
    {
        Console.Write(str[k]);
        if (i > 1)
        {
            Console.Write(str3);
        }
            
        else
        {
            Console.Write("it");
        }
    }

        Console.Write(str1);
}



else if (i % 2 != 0)



{
    for (int k = 0; k < i - 1; k++)
    {
        Console.Write(str[k]);
        if (i > 1)
        {
            Console.Write(str3);
        }

        else
        {
            Console.Write("it");
        }







    }
    Console.Write(str2);
    



}
    









