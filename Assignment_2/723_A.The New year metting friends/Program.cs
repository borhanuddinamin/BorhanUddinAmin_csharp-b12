// See https://aka.ms/new-console-template for more information
string     str =  Console.ReadLine();
int[] sss = new int[str.Length];
sss= Array.ConvertAll(str.Split(' '), int.Parse);
int max = sss[0];
int min = sss[0];


foreach (int i in sss)
{
    if (i >= max)
    {
        max = i;
    }
    else if(i <= min) {
        min=i;
    }

}
Console.WriteLine(max-min);