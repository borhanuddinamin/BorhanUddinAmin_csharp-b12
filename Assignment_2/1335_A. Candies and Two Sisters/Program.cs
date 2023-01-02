// See https://aka.ms/new-console-template for more information
int inputLine = Convert.ToInt32(Console.ReadLine());
int[] Value = new int[inputLine];
for (int i=0; i < inputLine; i++)
{

    Value[i] = Convert.ToInt32(Console.ReadLine());

}




foreach( var ss in Value)
{
    int  s = (ss - 1)/2;
 if (s >= 1){
        Console.WriteLine(s);
    }else if (s < 1)
    {
        Console.WriteLine("0");
            }
    
    

}