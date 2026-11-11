namespace LogicLibrary.Core.Abstractions;

public abstract class Gate(string? name, Pin[] inputs) : Component(name)
{
    protected Pin[] Inputs { get; private set; } = inputs;
    public Pin Output { get; private set; } = new(string.Empty, Signal.Unknown);

    public abstract void Evaluate();
}