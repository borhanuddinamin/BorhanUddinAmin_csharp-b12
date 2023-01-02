// See https://aka.ms/new-console-template for more information
int[] Input = new int[5];
for (int j = 0; j < 5; j++)
{
    Input[j] = int.Parse(Console.ReadLine());
}

int dragons = 0;
for (int i = 1; i <= Input[4]; i++)
{
    if (i%Input[0]  == 0 || i%Input[1]  == 0 || i%Input[2] == 0 || i%Input[3]== 0)
    {

        dragons++;
    }

}
Console.WriteLine(dragons);