// See https://aka.ms/new-console-template for more information
long[] t1 ;
string str = Console.ReadLine();

t1  = Array.ConvertAll(str.Split(' '), long.Parse);
long[] t2 = new long[t1[0]];

string str2 = Console.ReadLine();
t2 = Array.ConvertAll(str2.Split(' '), long.Parse);

long sum = 0;


foreach (var t in t2)
{
    long factorial = 1;

    for (long i = 1; i <= t; i++)
    {
        factorial = factorial * i;
       

    }

    sum = sum + factorial;
    
}


long divisor = 1;
for (long i = 2; i <= t1[1]; i++)
{
    divisor = divisor * i;
    

}





 if (sum % divisor == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} 


