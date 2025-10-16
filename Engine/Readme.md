How to Run on Windows

Create a new C# Console Project

dotnet new console -n CircleCoreEngine
cd CircleCoreEngine


Replace Program.cs with the code above (EngineRunner.cs).

Build and run

dotnet run


Example Commands

ADD R0 R1       -> Adds R0 + R1 and stores in R0
SUB R2 R1       -> Subtracts R1 from R2 and stores in R2
GPU 5           -> Simulates GPU compute with input 5
EXIT            -> Stops the engine


✅ This gives you a basic interactive CPU/GPU simulation on Windows. You can now expand it with more instructions, multi-core support, and GPU lanes.
