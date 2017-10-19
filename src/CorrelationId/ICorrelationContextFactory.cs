namespace CorrelationId
{
    public interface ICorrelationContextFactory
    {
        CorrelationContext Create(string correlationId);
    }
}
