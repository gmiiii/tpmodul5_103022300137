using System;

public class Program
{
    public static void Main(string[] args)
    {
        haloGeneric halo = new haloGeneric();
        halo.sapaUser("Gumilar Hari Subagja");
        DataGeneric<long> dataInt = new DataGeneric<long>(103022300137);
        dataInt.tampilData();
    }
}

class DataGeneric<T>
{
    public T data { get; set; }
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void tampilData()
    {
        Console.WriteLine("Data: " + data);
    }
}

public class haloGeneric
{
    public void sapaUser<T>(T nama)
    {
        Console.WriteLine("Halo " + nama);
    }
}
