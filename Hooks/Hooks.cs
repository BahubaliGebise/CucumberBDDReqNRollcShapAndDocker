// Hooks/Hooks.cs
using Reqnroll;

[Binding]
public class Hooks
{
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        // Additional setup if needed
    }
}
