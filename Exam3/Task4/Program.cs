using System.Text;

FileStream stream = File.OpenRead("Task4.txt");

    byte[] buffar = new byte[8];
    int bytesRead;
    while ((bytesRead = stream.Read(buffar, 0, 8)) > 0)
{

    Console.WriteLine($" {Encoding.UTF8.GetString(buffar, 0, bytesRead)}");


}
    
      
