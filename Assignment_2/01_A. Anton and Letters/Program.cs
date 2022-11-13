string  st= Console.ReadLine() ;
char[] separetor = { '{', '}',  ' ' };

string  stUpdate = st.Trim(separetor);
Console.WriteLine(stUpdate);
char[] separetor1 = { ',' };

string stUpdate1 = stUpdate.Trim(separetor1);
Console.WriteLine(stUpdate1);

char  [] result= new char [stUpdate1.Length];




//char[] result2= new char[result.Length];

int l = 0;
int sum = 0;


    for (int j=1; j<  result.Length;j++)
    {

        if (stUpdate[l] != stUpdate1[j])
        {
             result[l] = stUpdate1[j-1];
         
            Console.WriteLine(result[l]);
            sum=sum+1;
        l++;
    }
        
    

}

Console.WriteLine(sum);

Console.ReadKey();