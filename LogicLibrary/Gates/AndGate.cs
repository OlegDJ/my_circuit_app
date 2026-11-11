using LogicLibrary.Core;
using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Gates;

public class AndGate(string? name, Pin[] inputs) : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<Signal> inputSignals = [.. Inputs.Select(pin => pin.Signal) ];
        
        if (inputSignals.Contains(Signal.Low))
            Output.Signal = Signal.Low;
        else if (inputSignals.Contains(Signal.Unknown))
            Output.Signal = Signal.Unknown;
        else
            Output.Signal = Signal.High;
    }
}