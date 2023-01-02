// See https://aka.ms/new-console-template for more information
int[] value = Array.ConvertAll((Console.ReadLine().Split()), int.Parse);





for(int i=0; i<value.Length-1; i++)
{

    if (value[i] >value[i+1])
    { int cs = value[i+1];
        
        value[i+1]= value[i];
        value[i] = cs;
    }
}

int c = value[3] - value[0];
int b = value[2] - c;
int a = value[3] - (b + c);
Console.WriteLine($"{a} {b} {c}");
