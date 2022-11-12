// See https://aka.ms/new-console-template for more information
using Task3;

DatabaseConnection Dbc = new DatabaseConnection("Connected");
Console.WriteLine(Dbc.connectionString);