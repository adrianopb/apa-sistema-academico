namespace final2.Domain
{
    public interface IAggregateRoot : IEntity
    {
        int Version { get; }
    }
}