using System;
using Sys = Cosmos.System;

namespace NexonKernel {
  public class kernel : Sys.Kernel {
    protected override void BeforeRun() {
      System = Console.WriteLine("Welcome To " + ConsoleColor.Cyan + "NexonKernel");
    }

    protected override void Run() {
      var Console = Console.WriteLine($"Root@" + Consolecolor.Cyan + "NexonKernel: ~$ ");
      var ConsoleRead = Console.ReadLine(Console);
    }
  }
}
