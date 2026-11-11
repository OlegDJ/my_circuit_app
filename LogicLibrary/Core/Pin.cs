using LogicLibrary.Core.Abstractions;

namespace LogicLibrary.Core;

// Can Pin be considered a Component? Maybe different name for Component?
// Also, why would pin have a name?
public class Pin(string? name, Signal? signal) : Component(name)
{
    public Signal Signal { get; set; } = signal ?? Signal.Low;
}