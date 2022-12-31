// See https://aka.ms/new-console-template for more information
string str = Console.ReadLine();
int money = Convert.ToInt32(str);
int hunders = 0;
int tweenty = 0;
int ten = 0;
int five=0;
int one = 0;
for (int i = str.Length*2; i >0 ; i--)
{
    if (money >= 100)
    {
        hunders = money / 100;
        money = money % 100;

      
    }else if ( money >= 20)
    {
        tweenty = money / 20;
        money = money % 20;

    }else if ( money >= 10)
    {
        ten = money / 10;
        money = money % 10;
    }else  if (money >= 05)
    {
        five = money / 5;
        money = money % 5;
    }else 
    {
        one = money / 1;
    }
}

int bills = hunders+tweenty+ten+five+one;
Console.WriteLine(bills);