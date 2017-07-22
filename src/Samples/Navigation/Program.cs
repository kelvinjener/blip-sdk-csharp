﻿using System.Threading.Tasks;
using Take.Blip.Client.ConsoleHost;

namespace Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static Task MainAsync(string[] args) => ConsoleRunner.RunAsync(args);
    }
}