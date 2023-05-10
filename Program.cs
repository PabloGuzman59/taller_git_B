namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, World!");
            int n1= 5;
            int n2 = 5;
            int suma;
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            suma = n1 + n2;
            Console.WriteLine("Suma de dos numeros es " + suma);
            Console.WriteLine(edad);
        }
    }
}