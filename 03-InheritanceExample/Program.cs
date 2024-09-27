// See https://aka.ms/new-console-template for more information
using Inhetitance;

Console.WriteLine("Hello, World!");
Admin admin = new Admin("salesman", "Shopping", "Elias Zare", "a C# Programmer I coding Asp for my website");
Console.WriteLine(admin.GetFullBio());
Console.ReadKey();