
internal class Program
{
    private static void Main(string[] args)
    {
        // This is a simple C# program that prints "Hello, World!" to the console.  
        Console.WriteLine("Hello, World!");
        int a;
        a = 1; // Fixed missing semicolon  
        Console.WriteLine($"The value of a is: {a}"); // Fixed typo: Changed 'onsole' to 'Console'

        // Wait for user input before closing the console window  
        Console.ReadLine();
    }
}
