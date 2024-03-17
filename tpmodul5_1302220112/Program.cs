using System;

class HelloGeneric
{
    public static void sapaUser<T>(T Tinput)
    {
        Console.WriteLine("Hello user " +  Tinput);
    }
/*    public static void Main(string[] args)
    {
        Console.Write("Masukkan Nama: ");
        String nama = Console.ReadLine();
        sapaUser(nama);
    }*/
}
