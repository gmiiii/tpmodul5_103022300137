﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

public class HaloGeneric
{
    public void sapaUser<T>(T user)
    {
        Console.WriteLine("Halo, " + user);
    }   
}