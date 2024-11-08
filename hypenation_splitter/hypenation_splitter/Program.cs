﻿// See https://aka.ms/new-console-template for more information
using hypenation_splitter;

Console.WriteLine("Hello, World!");
Transform transform = new();

if (args.Length == 0)
{
    Console.WriteLine("no input data!");
    return;
}

try
{
    transform.Proccess(args[0]);
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}
