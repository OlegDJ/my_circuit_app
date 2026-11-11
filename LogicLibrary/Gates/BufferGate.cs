using LogicLibrary.Core;
using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Gates;

public class Buffer(string? name, Pin input) : Gate(name, [input])
{
    public override void Evaluate()
    {
        Output.Signal = Inputs[0].Signal;
    }
}