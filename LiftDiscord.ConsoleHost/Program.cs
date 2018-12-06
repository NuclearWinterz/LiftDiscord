﻿using System.Threading.Tasks;
using LiftDiscord.DiscordClient;

namespace LiftDiscord.ConsoleHost
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var key = System.Environment.GetEnvironmentVariable("....");

            var client = new Client(key);
            await client.RunAsync();
        }
    }
}