using System;
public static class Program
{
    public static void Main(string[] args)
    {
        haloGeneric halo = new haloGeneric();
        halo.sapaUser("Gumilar Hari Subagja");
    }
}
public class haloGeneric
{
    public void sapaUser<T>(T nama)
    {
        Console.WriteLine("Halo " + nama);
    }
}