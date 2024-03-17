using System;
namespace tpmodul5_1302220112;
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