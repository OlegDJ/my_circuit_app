using LogicLibrary.Core;
using LogicLibrary.Gates;

#region Setup, Initial Values
Pin inputA = new("A", Signal.Low);
Console.WriteLine($"Initially, let A be {inputA.Signal}.");
Pin inputB = new("B", Signal.Low);
Console.WriteLine($"Initially, let B be {inputB.Signal}.");

XorGate xorGate = new("Xor", [inputA, inputB]);
xorGate.Output.Name = "S";
Pin outputS = xorGate.Output;
Console.WriteLine($"Before evaluating, {outputS.Name} is {outputS.Signal}.");

AndGate andGate = new("And", [inputA, inputB]);
andGate.Output.Name = "C";
Pin outputC = andGate.Output;
Console.WriteLine($"Before evaluating, {outputC.Name} is {outputC.Signal}.");

EvaluateAndPrint();
#endregion

#region Carry
Console.WriteLine("\nNow, let's try getting a carry out.");

inputA.Signal = Signal.High;
Console.WriteLine($"Let {inputA.Name} be {inputA.Signal}.");
inputB.Signal = Signal.High;
Console.WriteLine($"Let {inputB.Name} be {inputB.Signal}.");

EvaluateAndPrint();
#endregion

#region Sum
Console.WriteLine("\nNow, let's try getting a sum.");

inputA.Signal = Signal.Low;
Console.WriteLine($"Let {inputA.Name} be {inputA.Signal}.");
inputB.Signal = Signal.High;
Console.WriteLine($"Let {inputB.Name} be {inputB.Signal}.");

EvaluateAndPrint();
#endregion

#region Undefined
Console.WriteLine("\nNow, let's try setting an undefined input.");

inputA.Signal = Signal.Unknown;
Console.WriteLine($"Let {inputA.Name} be {inputA.Signal}.");
inputB.Signal = Signal.Low;
Console.WriteLine($"Let {inputB.Name} be {inputB.Signal}.");

EvaluateAndPrint();

Console.WriteLine($"Notice: {outputC.Name} is {outputC.Signal}. " +
    $"That's because {inputA.Signal} {inputA.Name} does not matter " +
    $"when evaluating AND gate {inputB.Name} is {inputB.Signal}.");
#endregion

void EvaluateAndPrint()
{
    xorGate.Evaluate();
    Console.WriteLine($"After evaluating, {outputS.Name} is {outputS.Signal}.");
    andGate.Evaluate();
    Console.WriteLine($"After evaluating, {outputC.Name} is {outputC.Signal}.");
}