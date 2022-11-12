// See https://aka.ms/new-console-template for more information
using Task4;

Teacher T1 = new Teacher("MAmhud", "hasan", "mahmudH@gmail.com");
T1.GenerateId("TE-");
Console.WriteLine($"Full Name : {T1.FullName}\n Email {T1.Email}\n Teacher ID:{T1.Id}\n");



Student  S1 = new Student("MAmhudul", "hasan", "mahmudH@gmail.com");
S1.GenerateId("ST-");
Console.WriteLine($"Full Name : {S1.FullName}\n Email {S1.Email}\n Student ID:{S1.Id}\n");


Admin A1 = new Admin("MAmhud alam", "hasan", "mahmudH@gmail.com");
A1.GenerateId("AD-");
Console.WriteLine($"Full Name : {A1.FullName}\n Email {A1.Email}\n Admin ID:{A1.Id}\n");
