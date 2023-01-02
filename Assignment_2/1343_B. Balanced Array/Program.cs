// See https://aka.ms/new-console-template for more information
int line = int.Parse(Console.ReadLine());

int[] Input = new int[line];
for (int i = 0; i < line; i++)
{
    Input[i] = int.Parse(Console.ReadLine());
}
int[] Firstresult = new int[line / 2];


int[] Secondresult = new int[line / 2];


for (int j = 0; j < line; j++)
{

    if (Input[j] % 2 != 0)
    {
        Console.WriteLine("No");
    }

    while (j < Input[j] / 2)
    {


        int res = Input[j];
        for (int i = 2; i < line / 2; i = i + 2)
        {
            res = res - 2;
            Firstresult[j] = res;

        }

    }
    while (j > Input[j] / 2)
    {

        int res = Input[j];
        for (int i = Input[j]; i >= line/2; i = i + 2)
        {
            res = res - 2;
            Firstresult[i] = res;

        }




    }

}














