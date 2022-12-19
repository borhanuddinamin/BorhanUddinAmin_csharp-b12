// See https://aka.ms/new-console-template for more information
int read = Convert.ToInt32(Console.ReadLine());
int[] ss = new int[read];


    string s = Console.ReadLine();
    ss = Array.ConvertAll(s.Split(' '), int.Parse);


double sum = 0;
foreach (int i in ss)
{
    sum = sum +i;
}
Console.WriteLine(sum/read);
