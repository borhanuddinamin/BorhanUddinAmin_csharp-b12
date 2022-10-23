// See https://aka.ms/new-console-template for more information
//TASK 1 Solution:

//taking user Input of 2D array row Size

ParameterizedThreadStart:


Console.WriteLine("Please Enter The 2D Array Rows Number");

int row = Convert.ToInt32(Console.ReadLine());

//taking user Input of 2D array column Size

Console.WriteLine("Please Enter The number of column");
int coloum = Convert.ToInt32(Console.ReadLine());

if ((row < 3 || coloum < 3) || (row > 1000 || coloum > 1000))
{
    Console.WriteLine("Please Enter Row and column size from 3 to 1000\n");
    goto ParameterizedThreadStart;
}





int[,] TwoDarray = new int[row, coloum];

// taking 2D array Element from user
Console.WriteLine("Please Enter the Elements of the array");


for (int c = 0; c < row; c++)
{
    string element = Console.ReadLine();
    for (int f = 0; f < coloum; f++)
    {
        char[] Divided = { ' ' };


        string[] elements = element.Split(Divided);


        TwoDarray[c, f] = Convert.ToInt32(elements[f]);


    }

}

//rows and columns addition result  holding in a array

int Totttal = (row + coloum) + 1;
int[] RowSum = new int[Totttal];




//calculate addtion on rows

for (int i = 0; i < row; i++)
{

    int sum = 0;
    for (int l = 0; l < TwoDarray.GetLength(1); l++)
    {
        sum = sum + TwoDarray[i, l];


    }

    RowSum[i] = sum;
}



//calculate addtion on columns

for (int p = 0; p < coloum; p++)
{
    int sum2 = 0;
    for (int q = 0; q < row; q++)
    {
        sum2 = TwoDarray[q, p] + sum2;




    }

    RowSum[(row + p)] = sum2;

}


//Dimestion addtion calculate on array

int sum3 = 0;

for (int r = 0; r < row; r++)
{
    if (r < coloum)
    {
        sum3 = TwoDarray[r, r] + sum3;

    }
    else
    {
        break;
    }



}


RowSum[(Totttal - 1)] = sum3;

// compare the value 

for (int x = 0; x < RowSum.Length; x++)
{
    if (RowSum[0] <= RowSum[x])
    {
        RowSum[0] = RowSum[x];
    }
}

Console.WriteLine(" Maximum sum value in  this Array : {0}", RowSum[0]);
