using System;
using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;
StringCollection remove = new StringCollection();


string st = Console.ReadLine();
string[] values= st.Split(',',' ', '{', '}').ToArray();
string str2 = string.Join("", values);


string  [] ch = new string [str2.Length];
int i = 0;
foreach(var s in str2)
{
    ch[i]=Convert.ToString(s);
    i++;
}


int l = 0;
int m = 0;


remove.AddRange(ch);

for (int b = 0; b < str2.Length; b++)
{


    for (int a =b+ 1; a< str2.Length; a++)
    {
        

        if (ch[b] == ch[a])
        {
            //remove.RemoveAt(a - l)
         Console.WriteLine( a );
            Console.WriteLine(a - l);
            l++;
         
       //ch = ch.Where(e => e == ch[a]).ToArray();

        }
        /*else if (ch[b] != ch[a])
        {
            m=m+1;
            //ch = ch.Where(e => e == ch[a]).ToArray();
            Console.WriteLine(m);
        }*/
    }
    if (l >0)
    {



       
    }
   


}

foreach (var c in remove)
{
    Console.WriteLine(c);
}


Console.WriteLine(l);

//Console.WriteLine(str2.Length );

//Console.WriteLine(l);
//Console.WriteLine(m);

//Console.WriteLine(m);
//Console.WriteLine(sum);
/*for (int m=0; m< str2.Length;m++)
    {
        if (value2 == ch[m])
        {
            sum++;
            Console.WriteLine(sum);
        }
        
    }
*/
