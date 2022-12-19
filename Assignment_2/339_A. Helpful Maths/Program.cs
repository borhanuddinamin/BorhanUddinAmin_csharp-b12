// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();
int one = 0;
int two = 0;
int three = 0;
int plus = 0;
foreach(char ch in str)
{
    if (ch == '1')
    {
        one++;
    }else if (ch == '2')
    {
        two++;
    }else if(ch == '3')
    {
        three++;
    }else
    {
        plus += 1;
    }
}



if (one > 0)
{
    for (int i = 0; i < one; i++)
    {
        Console.Write($"1");
        if (plus > 0)
        {
            Console.Write($"+");
            plus -= 1;
        }
    }


};







if (two > 0)
{
    for (int i = 0; i < two; i++)
    {
        Console.Write($"2");

        if (plus > 0)
        {
            Console.Write($"+");
            plus -= 1;
        }
    }
};


if (three > 0)
{
    for (int i = 0; i < three; i++)
    {
        Console.Write($"3");

        if (plus > 0)
        {
            Console.Write($"+");
            plus -= 1;
        }
    }
};
