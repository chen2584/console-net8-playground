using MyConsole;

var myPrimaryConstructorClass = new MyPrimaryConstructorClass("Chen", 30);
Console.WriteLine($"Name: {myPrimaryConstructorClass.Name}, Age: {myPrimaryConstructorClass.Age}");

List<int> firstList = [1, 2, 3, 4, 5];
List<int> secondList = [6, 7, 8, 9, 10];
List<int> combinedList = [..firstList, ..secondList];
Console.WriteLine(string.Join(", ", combinedList));

var defaultLambda = (string name, int age = -1) => Console.WriteLine($"Name: {name}, Age: {age}");
defaultLambda("Chen Angelo");

var buffer = new MyBuffer();
for (int i = 0; i < 10; i++)
{
    buffer[i] = i;
}

foreach (var i in buffer)
{
    Console.WriteLine(i);
}

object obj = new MyPrimaryConstructorClass("Chen", 30);
if (obj is MyPrimaryConstructorClass { Name: "Chen" } and { Age: >= 30 })
{
    Console.WriteLine("Age is more than 30");
}

var myClass = new MyClass();
MyPrimaryConstructorClass.ForceByRef(in myClass);
MyPrimaryConstructorClass.ForceByRef(ref myClass);
// MyPrimaryConstructorClass.ForceByRef(out myClass); // Error
MyPrimaryConstructorClass.ForceByRef(myClass); // Warning
MyPrimaryConstructorClass.ForceByRef(new MyClass()); // Warning
Console.WriteLine($"MyClass's Name is {myClass.Name}");