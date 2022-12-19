// See https://aka.ms/new-console-template for more information

string str = Console.ReadLine();
int sum = 0;
foreach(char s in str)
{
    if (s == 'H' || s == 'Q' | s == '9')
    {
        Console.WriteLine("YES");
        sum=sum+1;
        break;

    }
 

};
if (sum == 0)
{
    Console.WriteLine("NO");

}