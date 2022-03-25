using System;
public class overide : Program
{
    public override void penjumlahanperkaliandll()
    {
        Console.WriteLine("Overiding 2........======>>>>>>>");
        Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
        Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2} \n\n", bilangan1, bilangan2, bilangan1 - bilangan2);
    }

    // public void penjumlahanperkaliandll()
    // {
    //     Console.WriteLine("Overiding 2........======>>>>>>>");
    //     Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
    //     Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2} \n\n", bilangan1, bilangan2, bilangan1 - bilangan2);
    // }

    static void Main(string[] args)
    {
        // overide overiding = new overide();
        // overiding.bilangan(20, 5);
        // overiding.penjumlahanperkaliandll();

        // overiding = new Program();
        // overiding.bilangan(10, 5);
        // overiding.penjumlahanperkaliandll();
        
        Program overiding1 = new Program();
        overiding1.bilangan(10, 5);
        overiding1.penjumlahanperkaliandll();

        overiding1 = new overide();
        overiding1.bilangan(20, 5);
        overiding1.penjumlahanperkaliandll();
        Console.Read();

        // Program overiding2 = new Program();
        // overiding2.bilangan(10, 5);
        // overiding2.penjumlahanperkaliandll();
        // Console.WriteLine("Overide");
    }
}
