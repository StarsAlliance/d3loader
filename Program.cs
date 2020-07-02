﻿using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using D3Loader.Properties;

namespace D3Loader
{
    internal static class Start
    {
        private static void Main(string[] args)
        {
            var d3 = new Process();
            const string exec = "Diablo III.exe";
            if (File.Exists(exec))
            {
                d3.StartInfo.FileName = exec;
                d3.StartInfo.Arguments = "-launch";
                d3.StartInfo.CreateNoWindow = true;
                d3.StartInfo.UseShellExecute = false;
                System.Console.WriteLine("Starting the game");
                d3.Start();
            }
            else
            { 
                System.Console.WriteLine(exec, " wasn't found"); //error message
                System.Threading.Thread.Sleep(2000); //Pause before closing
            }
        }
    }
}
