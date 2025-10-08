using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace HolaTimer.Tests;

[TestClass]
public class TimerTests
{
    [TestMethod]
    public async Task EsperaTresSegundosYLoguea()
    {
        Console.WriteLine("Iniciando prueba: esperando 3 segundos...");
        await Task.Delay(TimeSpan.FromSeconds(3));
        Console.WriteLine("Terminó el timer (prueba).");
        Assert.IsTrue(true); // dummy assert para que cuente como pasada
    }
}
