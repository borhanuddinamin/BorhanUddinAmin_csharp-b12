// See https://aka.ms/new-console-template for more information
int line = Convert.ToInt32(Console.ReadLine());

string[] str = new string[line];
for (int i = 0; i < str.Length; i++)
{
    str[i] = Console.ReadLine();
}

string str2= string.Join(" ", str);

int[] sss = new int[str2.Length];

sss = Array.ConvertAll(str2.Split(' '), int.Parse);


int  Mishka=0;
int  Chris = 0;
int Friendships = 0;


int v = 1;                                                                                                                                   ;

for (int i = 0; i < sss.Length; i=i+2)
{
    if (sss[i] > sss[v])
    {
        Mishka = Mishka + 1;
    } else if (sss[i] < sss[v])
    {
        Chris= Chris + 1;
    }
    else if (sss[i] == sss[v])
    {
        Friendships = Friendships + 1;
    }


    v =v+2;

}



if (Mishka>Chris)
{
    Console.WriteLine("Mishka");
}else if (Mishka < Chris )
{
    Console.WriteLine("Chris");
}
else if(Mishka == Chris)
{
    Console.WriteLine("Friendship is magic!^^");
}





