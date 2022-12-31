// See https://aka.ms/new-console-template for more information
int line = Convert.ToInt32(Console.ReadLine());

int[] intvalue = new int[line];

    string str = Console.ReadLine();
intvalue = Array.ConvertAll(str.Split(' '), int.Parse);
int max_index= 0;
int min_index = 0;
int max_value = intvalue[0];
int min_value = intvalue[0];
for (int i = 0; i < intvalue.Length; i++)
{
       if(min_value >= intvalue[i ])
        {
       
            min_value =  intvalue[i];
    
        min_index = i + 1;
        }
    
    if (max_value <= intvalue[i])
        {
            max_value =   intvalue[i];
        
        max_index = i + 1;
        }
        

}
// max_index= + 1;
//min_index =+ 1;

//Console.WriteLine(min_index);
//Console.WriteLine(max_index);
//Console.WriteLine(middle);

double middle = line / 2;



int max_Ds = 0;
int min_Ds = 0;

if (min_index < line)
{
     
     min_Ds = line - (min_index) ;

}
if(max_index > 1)
{
    max_Ds = max_index-1 ;
}

//Console.WriteLine(max_Ds);
//Console.WriteLine(min_Ds);



if ((min_index == line) && (max_index == 1))
{
    Console.WriteLine("1");

}else if ((min_Ds == 1) && (max_Ds == 1))
{
    Console.WriteLine("1");


}
int result = max_Ds + min_Ds;

if ((max_Ds > middle) && (min_Ds > middle))
{
    result = result - 1;

    Console.WriteLine(result);
    //Console.WriteLine(max_Ds);
}
else if((max_Ds < middle) && (min_Ds < middle)&& (max_Ds > 1) && (min_Ds > 1))
{

    Console.WriteLine(result);
}
/*else if (min_Ds > middle)
{
    result = result - 1;
    //Console.WriteLine(min_Ds);
}*/
//Console.WriteLine(max_Ds);
//Console.WriteLine(min_Ds);











/*if (max_Ds > min_Ds)
{
    //int result = max_index - min_index - 1;

    Console.WriteLine(max_Ds);
}
else if (max_Ds < min_Ds)
{
   // int result = min_index - max_index - 1;
    Console.WriteLine(min_Ds);
}
else if (max_Ds == min_Ds)
{
    int result = max_Ds + min_Ds;
    Console.WriteLine(result);

}
*/








/*
if (max_index > min_index && min_index != 0)
{
    int result =  max_index- min_index  - 1;

    Console.WriteLine(result);
}
else if (max_index < min_index && min_index != 0)
{
    int result =  min_index- max_index  -1 ;
    Console.WriteLine(result);
}
else if(max_index < min_index && min_index == 0)
{
    int result = (min_index - max_index - 1) * 2;
    Console.WriteLine(result);

}

*/
