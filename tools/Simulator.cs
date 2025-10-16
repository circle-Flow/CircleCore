using System;

namespace CircleCoreSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CircleCore CPU/GPU Simulation Started");

            // Simple CPU simulation: ADD two registers
            int[] regFile = new int[8];
            regFile[1] = 10;
            regFile[2] = 20;

            int aluResult = regFile[1] + regFile[2];

            Console.WriteLine($"CPU ALU Result (R1 + R2): {aluResult}");

            // Simple GPU simulation
            int[] lanes = new int[4];
            int data_in = 5;
            int data_out = 0;
            for (int i = 0; i < 4; i++)
            {
                lanes[i] = data_in * (i + 1) * 2;
                data_out += lanes[i];
            }

            Console.WriteLine($"GPU Data Output: {data_out}");
            Console.WriteLine("Simulation Finished.");
        }
    }
}
