using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace HolaTimer.Tests;

[TestClass]
public class TimerTests
{
    // MSTest inyecta el contexto
    public TestContext TestContext { get; set; } = default!;

    // Helpers para leer parámetros con fallback a env vars y defaults
    private string GetParam(string name, string? env = null, string defaultValue = "")
    {
        if (TestContext.Properties.ContainsKey(name))
            return Convert.ToString(TestContext.Properties[name]) ?? defaultValue;

        var envVal = Environment.GetEnvironmentVariable(env ?? name);
        return string.IsNullOrEmpty(envVal) ? defaultValue : envVal!;
    }

    private int GetIntParam(string name, string? env = null, int defaultValue = 3000)
    {
        var raw = GetParam(name, env, defaultValue.ToString());
        return int.TryParse(raw, out var v) ? v : defaultValue;
    }

    private bool GetBoolParam(string name, string? env = null, bool defaultValue = false)
    {
        var raw = GetParam(name, env, defaultValue.ToString());
        return bool.TryParse(raw, out var v) ? v : defaultValue;
    }

    [TestMethod]
    public async Task EsperaConParametros_Y_Loguea()
    {
        // Ejemplos de parámetros que vamos a pasar desde el workflow:
        // CameraIp, DelayMs, ShouldFail
        var cameraIp  = GetParam("CameraIp", "CAMERA_IP", "127.0.0.1");
        var delayMs   = GetIntParam("DelayMs", "DELAY_MS", 2500);
        var shouldFail= GetBoolParam("ShouldFail", "SHOULD_FAIL", false);

        Console.WriteLine($"[Test] CameraIp={cameraIp}  DelayMs={delayMs}  ShouldFail={shouldFail}");
        await Task.Delay(delayMs);
        Assert.IsTrue(!shouldFail, "Se forzó el fallo via parámetro ShouldFail=true");
    }

    [TestMethod]
    public void prueba_0() => Assert.IsTrue(true);

    [TestMethod]
    public void prueba_1() => Assert.IsTrue(true);

    [TestMethod]
    public void prueba_2() => Assert.IsFalse(true); // falla adrede

    [TestMethod]
    public void prueba_3() => Assert.IsTrue(true);
}
