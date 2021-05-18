using System.Threading.Tasks;

namespace Restaurant.BLL.Interfaces.IServices
{
    public interface IBaseService<T>
    {
        T Insert(T entity);

        T Delete(T entity);

        T Update(T entity);
    }
}