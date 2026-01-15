namespace Vaja3;


internal class Program
{
    private static void Main(string[] args)
    {
        Primer1();
        Primer2();

    }

    public static void Primer1()
    {
        int a = 5;
        int b = 10;
        int c = a + b;


        Console.WriteLine("c(a+b): " + c + " a: " + a + " b: " + b);

    }

    public static void Primer2()
    {
        string ime = "Janez";
        string priimek = "Novak";
        string polnoIme = ime + " " + priimek;
        Console.WriteLine("Polno ime: " + polnoIme);
    }





}


