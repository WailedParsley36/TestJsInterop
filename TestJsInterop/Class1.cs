
using Microsoft.JavaScript.NodeApi;
using TestJsInterop.Structures;

/// <summary>
/// Example Node API module that exports a simple "hello" method.
/// </summary>
[JSExport]
public static class Example
{
    /// <summary>
    /// Gets a greeting string.
    /// </summary>
    /// <param name="greeter">Name of the greeter.</param>
    /// <returns>A greeting with the name.</returns>
    public static string Hello(string greeter)
    {
        System.Console.WriteLine($"Hello {greeter}!");
        return $"Hello {greeter}!";
    }

    public static TestType ImportTestType(TestType imported)
    {
        return imported;
    }
}