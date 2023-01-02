// See https://aka.ms/new-console-template for more information
int Line = int.Parse(Console.ReadLine());
string[] collect = new string[Line];

for (int i=0; i < Line; i++)
{
    collect[i] = Console.ReadLine();
    


}
string[] result = new string[Line];



int n = 0;

foreach (var ss in collect)
{
    char[] ch = ss.ToCharArray();
    int count = 0;
    if (ch.Length % 2 == 1)
    {
        result[n] = "No";


    }
    else if (ch.Length % 2 == 0)
    {
        for (int j = 0; j < ch.Length / 2; j++)
        {
           
                if (ch[j] == ch[j + ch.Length / 2])
                {
                    count++;
                }

            
            

        }



        if (count > 0 && count *2==ch.Length)
        {
            result[n] = "Yes";

        }
       
        else 
        {
            result[n] = "No";
        }


    }
    n++;
}

foreach (var s in result)
{
    Console.WriteLine(s);


}