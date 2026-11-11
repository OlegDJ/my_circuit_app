using LogicLibrary.Core;
using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Gates;

public class NandGate(string? name, Pin[] inputs) : Gate(name, inputs)
{
    public override void Evaluate()
    {
        List<Signal> inputSignals = [.. Inputs.Select(pin => pin.Signal) ];

        if (inputSignals.All(signal => signal == Signal.High))
            Output.Signal = Signal.Low;
        else if (inputSignals.Contains(Signal.Low))
            Output.Signal = Signal.High;
        else
            Output.Signal = Signal.Unknown;
    }
}