// See https://aka.ms/new-console-template for more information
using Task1;

Product Product1 = new Product("iphone 13",178000, "Midnight", "featuring the lightning-fast A15 Bionic, advanced camera systems, great battery life, impressive durability, and 5G");

Console.WriteLine($" Product: {Product1.Name}\n Price: {Product1.Price}\n color: {Product1.Color}\n Description: {Product1.Description}");