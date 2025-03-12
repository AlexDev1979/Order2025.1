namespace OrdenesPedidos.Frontend.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<T>> PostAsync<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);
    }
}