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


HashSet<string> value = new HashSet<string >();
foreach(var c in remove)
{

    value.Add(c);


}
Console.WriteLine(value.Count);