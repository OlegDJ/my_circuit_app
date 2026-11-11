namespace LogicLibrary.Core.Abstractions;

public abstract class Component(string? name)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string? Name { get; set; } = name;
}