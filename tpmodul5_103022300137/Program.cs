using System;

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.sapaUser("Gumilar Hari Subagja");
    }
}

public class HaloGeneric
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine("Halo, " + user);
    }   
}