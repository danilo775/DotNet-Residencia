// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data.Common;



List<(int id, string name, DateTime data)> list =new();
list.Add((11, "Danilo", new DateTime(2020,10,12)));
list.Add((12, "Aninha", DateTime.Now));
list.Add((13, "Juca", DateTime.Now));

list.ForEach(x => Console.WriteLine($"{x.id} - {x.name} - {x.data}"));



List<string> list1 = new List<string>() { "Danilo", "Aninha", "Juca" };

Console.WriteLine(list1.Any(x => x.Contains("a")));

