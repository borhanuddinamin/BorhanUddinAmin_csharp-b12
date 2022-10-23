// See https://aka.ms/new-console-template for more information

//task 2 Solution



long number1 = -922337203685477580;
long number2 = -922337203685477580;
long number3 = -922337203685477580;
long number4 = -922337203685477580;


//taking 
Console.WriteLine("Enter number of input");
int read = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Numbers");
for (int i = 0; i < read; i++)
{


    int Numbers = Convert.ToInt32(Console.ReadLine());


    if ((number1 < Numbers) && (number2 < Numbers))
    {
        number3 = number2;
        number2 = number1;

        number1 = Numbers;



    }
    else if ((number1 > Numbers) && (number2 < Numbers))
    {
        number4 = number3;
        number3 = number2;
        number2 = Numbers;

    }
    else if ((number2 > Numbers) && (number3 < Numbers))
    {
        number4 = number3;
        number3 = Numbers;

    }




}
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);