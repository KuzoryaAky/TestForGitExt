namespace TestGenericExtention
{
    internal abstract class Generic<T>
    {
        public abstract Task<bool> InitializeAsync(T orders, CancellationToken token = default);
        
    }
}
