using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Cosmos.System.Graphics;
using Cosmos.Core;
using Sys = Cosmos.System;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Cosmos.System.Network.IPv4;

namespace NexonKernel {
    public class kernel : Sys.Kernel {
        public static Canvas canvas;
        public static string username = "Root";
        public static string password = "1234";
        public static string version = "0.1.0";
        public static bool isInstaller = false;
        public static Bitmap bitmap = new Bitmap("Background.bmp");
        public void Login() {
            Console.Write($"Login: ");
            var login = Console.ReadLine();
            if (login == username) {
                Console.Write($"Password: ");
                var pass = Console.ReadLine();
                if (pass = password) {
                    Console.WriteLine(ConsoleColor.Red+"You Are Logged In As A Default Users:", username);
                    Run();
                else {
                    Console.WriteLine(ConsoleColor.Red+"Wrong Or Invaild Password.");
                    Login();
                }
            }
        protected override void BeforeRun() {
            Console.Clear();
            Console.WriteLine("Welcome To "+ConsoleColor.Cyan+"NexonKernel");
            Login();           
        }

        protected override void Run() {
            Console.Write(username+$"@"+ConsoleColor.Cyan+$"NexonKernel:~$ ");
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
                    loadgui();
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
                    Console.WriteLine($"Command '{words[0]}' Is not found in the command list. make sure you command are added, and try again.");
                    break;
            }
        }
    }
}
