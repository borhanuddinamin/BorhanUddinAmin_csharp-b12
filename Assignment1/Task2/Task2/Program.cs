// See https://aka.ms/new-console-template for more information


double number1 = Double.MinValue;
double number2 = Double.MinValue;
double number3 = Double.MinValue;
double number4 = Double.MinValue;


//taking  Input from user
Console.WriteLine("Enter number of input\n");
int read = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Numbers\n");

for (int i = 0; i < read; i++)
{


    double Numbers = Convert.ToDouble(Console.ReadLine());

    // checking numbers one by one
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

Console.WriteLine("Third largest number is {0}",number3);

