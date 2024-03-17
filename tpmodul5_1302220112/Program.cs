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
using System;
public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " +  Data);
    }
    
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.printData();
    }
}