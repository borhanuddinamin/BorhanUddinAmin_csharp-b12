// See https://aka.ms/new-console-template for more information
String SS= Console.ReadLine();

int year= Convert.ToInt32(SS);

string pp= SS;
int k = 0;
int n = 0;



char [] fg = new char [SS.Length+2];


for (int i = year; i <9000; i++)
{

    


    foreach (char  q in pp)
    {
        int digent = 0;


        for (int j = 1; j < SS.Length; j++) {
            

            if (q != pp[j])
            {
                digent= digent+1;

            }


            

        }



        if (digent <4)
        {
            fg[n] = q;
            n++;
        }

    }







    pp = Convert.ToString(i);







        if (fg.Length == 4)
        {
            foreach (int o in fg)
            {
                Console.Write(o);
            }
        }









    }
    


