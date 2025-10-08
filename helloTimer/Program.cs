using System;
using System.Threading.Tasks;

Console.WriteLine("Hola mundo");
await Task.Delay(TimeSpan.FromSeconds(3));
Console.WriteLine("Terminó el timer");
