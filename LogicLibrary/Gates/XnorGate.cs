using LogicLibrary.Core;
using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Gates;

public class XnorGate(string? name, Pin[] inputs): Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<Signal> inputSignals = [.. Inputs.Select(pin => pin.Signal) ];

        if (inputSignals.Contains(Signal.Unknown))
            Output.Signal = Signal.Unknown;
        else if (inputSignals.Count(state => state == Signal.High) % 2 == 0)
            Output.Signal = Signal.High;
        else
            Output.Signal = Signal.Low;
    }
}