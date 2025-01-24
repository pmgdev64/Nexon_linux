using System;
using System.Text;
using System.Collections.Generic;
using Cosmos.System.Graphics;
using Cosmos.Core;
using Sys = Cosmos.System;

namespace NexonKernel {
    public class kernel : Sys.Kernel {
        public static Canvas canvas;
        protected override void BeforeRun() {
            Console.WriteLine("Welcome To "+ConsoleColor.Cyan+"NexonKernel");
        }

        protected override void Run() {
            Console.Write($"Root@"+ConsoleColor.Cyan+"NexonKernel:~$ ");
            var input = Console.ReadLine();
            string[] words = input.Split(' ');
            switch (words[0])
            {
                case "GetCpuInformation":
                    Console.WriteLine($"[Vendor]: {CPU.GetCPUVendorName()}, [Name]: {CPU.GetCPUBrandString()}, [Freq]: {CPU.GetCPUCycleSpeed()}");
                    break;
                case "System" + words[1]:
                    switch (words[1])
                    {
                        case "--Shutdown":
                            Sys.Power.Shutdown(); // shutdown is supported
                        break;
                        case "--Reboot":
                            Sys.Power.Reboot(); // restart too
                        break;
                        default:
                            Console.WriteLine(ConsoleColor.Cyan+$"[SYSTEM] Bad Or Wrong Argument.");
                            break;
                    }
                case "LoadSystemFont":
                    Font ComicSans = new PCScreenFont(14, 14, "Sysfont/ComicSans.ttf", null);
                case "IntializeGUI":
                    var gui = FullScreenCanvas.GetFullScreenCanvas();
                case "Help!":
                    // console methods are plugged
                    Console.WriteLine(ConsoleColor.Red+"[NEXON KERNEL HELP COMMANDS]");
                    Console.WriteLine("Here Is All Of Displayed Command:");
                    Console.WriteLine("GETCPUINFORMATION                  Prints info about current cpu");
                    Console.WriteLine("SYSTEM   (--Shutdown, --Reboot)    Execute system functions");
                    Console.WriteLine("LOADSYSTEMFONT                     Loads current system font from directorl");
                    Console.WriteLine("INTIALIZEGUI                       Intialize the GUI");
                    Console.WriteLine("HELP                               Shows this help menu");
                    Console.WriteLine(ConsoleColor.Green+"For More Information, Visit https://kawaiiproject.neocities.org/Contents/nexon_kernel.");
                    break;
                default:
                    // switch operator works great
                    Console.WriteLine($"'"{words[0]}'" is not a command");
                    break;
        }
    }
}
