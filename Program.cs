using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace D3Loader
{
    class Start
    {
        static void Main(string[] args)
        {
            Process d3 = new Process();
            if (File.Exists("Diablo III.exe"))
            {
            d3.StartInfo.FileName = "Diablo III.exe";
            d3.StartInfo.Arguments = "-launch";
            d3.StartInfo.CreateNoWindow = true;
            d3.StartInfo.UseShellExecute = false;
            System.Console.WriteLine("Starting the game");
            d3.Start();
            }
            else
            { 
            System.Console.WriteLine("Diablo III.exe wasn't found!"); //error message
            System.Threading.Thread.Sleep(2000); //Pause before closing
            }
        }
    }
}
