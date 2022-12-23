namespace Stele.Portable.Nodes;

public enum ValueKind
{
    Reference,
    Tuple,
    Value,
}

public abstract class Value
{
    public ValueKind Kind;
}