using System;
using System.Threading;

namespace CircleCoreEngine
{
    // Simulated CPU core
    class CpuCore
    {
        public int[] RegFile { get; private set; } = new int[8];

        public int AluResult { get; private set; }

        public void Execute(string instr)
        {
            // Very simple instruction parser: "ADD R1 R2", "SUB R3 R0"
            var parts = instr.Split(' ');
            if (parts.Length != 3) return;

            int rd = int.Parse(parts[1].Replace("R", ""));
            int rs = int.Parse(parts[2].Replace("R", ""));

            switch (parts[0].ToUpper())
            {
                case "ADD":
                    RegFile[rd] = RegFile[rd] + RegFile[rs];
                    AluResult = RegFile[rd];
                    break;
                case "SUB":
                    RegFile[rd] = RegFile[rd] - RegFile[rs];
                    AluResult = RegFile[rd];
                    break;
                default:
                    Console.WriteLine("Unknown instruction");
                    break;
            }
        }
    }

    // Simulated GPU unit
    class GpuUnit
    {
        public int[] Lanes { get; private set; } = new int[4];
        public int Result { get; private set; }

        public void Compute(int input)
        {
            Result = 0;
            for (int i = 0; i < 4; i++)
            {
                Lanes[i] = input * (i + 1) * 2;
                Result += Lanes[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔹 CircleCore Engine Runner (Windows)");

            CpuCore cpu = new CpuCore();
            GpuUnit gpu = new GpuUnit();

            // Initialize some registers
            cpu.RegFile[0] = 5;
            cpu.RegFile[1] = 10;
            cpu.RegFile[2] = 20;

            while (true)
            {
                Console.WriteLine("\nEnter command:");
                Console.WriteLine("1. CPU instruction: e.g., ADD R0 R1");
                Console.WriteLine("2. GPU compute: e.g., GPU 5");
                Console.WriteLine("3. EXIT to quit");

                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;
                if (input.ToUpper() == "EXIT") break;

                if (input.ToUpper().StartsWith("GPU"))
                {
                    var parts = input.Split(' ');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int val))
                    {
                        gpu.Compute(val);
                        Console.WriteLine($"GPU Result: {gpu.Result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid GPU command. Format: GPU <value>");
                    }
                }
                else
                {
                    cpu.Execute(input);
                    Console.WriteLine($"CPU ALU Result: {cpu.AluResult}");
                    Console.WriteLine("Registers: " + string.Join(", ", cpu.RegFile));
                }
            }

            Console.WriteLine("Engine stopped.");
        }
    }
}
