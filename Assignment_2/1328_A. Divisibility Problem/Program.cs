// See https://aka.ms/new-console-template for more information

int line = Convert.ToInt32(Console.ReadLine());

int[] intvalue= new int[line*2];
int [] intvalue2=new int[line*2] ;
int j = 0;
for (int i = 0; i < line; i++)
{
    string str = Console.ReadLine();
 
   for (int k= 0; k < 2; k++)
    {
        intvalue2 = Array.ConvertAll(str.Split(' '), int.Parse);

        intvalue[j] = intvalue2[k];
        
        j++;
    }
}

for (int i = 0; i < line*2; i=i+2)
{
    if (intvalue[i] % intvalue[i+1]==0)
    {
        Console.WriteLine("0");
    }else if(intvalue[i] < intvalue[i + 1] )
    {
        Console.WriteLine( intvalue[i + 1]- intvalue[i] );
    }
    else
    {
        int remainder = intvalue[i] % intvalue[i + 1];
        Console.WriteLine(intvalue[i + 1] - remainder);

    }



}