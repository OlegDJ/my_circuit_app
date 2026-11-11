using LogicLibrary.Core;
using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Gates;

public class NotGate(string? name, Pin input) : Gate(name, [input])
{
    public override void Evaluate()
    {
        Signal inputSignal = Inputs[0].Signal;

        Output.Signal = inputSignal switch
        {
            Signal.High => Signal.Low,
            Signal.Low => Signal.High,
            _ => Signal.Unknown,
        };
    }
}