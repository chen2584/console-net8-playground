namespace MyConsole;

public class MyPrimaryConstructorClass(string name, int age)
{
    public string Name => name;
    public int Age => age;
    public MyPrimaryConstructorClass() : this ("N/A", -1)
    {
    }

    public static void ForceByRef(ref readonly MyClass myClass)
    {
        // myClass = new MyClass(); // Error because it readonly
        myClass.Name = "Hello";
        Console.WriteLine("ForceByRef Method is called.");
    }
}