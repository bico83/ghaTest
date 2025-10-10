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
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void prueba_0()
    {
        Console.WriteLine("Ejecutando prueba_0 -> Expected: true");
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void prueba_1()
    {
        Console.WriteLine("Ejecutando prueba_1 -> Expected: true");
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void prueba_2()
    {
        Console.WriteLine("Ejecutando prueba_2 -> Expected: false (falla apropósito)");
        Assert.IsTrue(false); // fuerza fallo si quisieras; aquí lo hacemos explícito:
        // Alternativa clara: Assert.IsFalse(true);  -- pero eso falla siempre.
    }

    [TestMethod]
    public void prueba_3()
    {
        Console.WriteLine("Ejecutando prueba_3 -> Expected: true");
        Assert.IsTrue(true);
    }
}
