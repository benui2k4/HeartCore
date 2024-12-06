using HeartCoreAPI.Models;

namespace HeartCoreAPI.Repositories
{
    public interface IDataRepository<T>
    {
        Task<ApiResponse> getAll();
        Task<ApiResponse> getById(int id);
        Task<ApiResponse> Create(T data);
        Task<ApiResponse> Delete(int id);
        Task<ApiResponse> Update(int id, T data);
    }
}
