using System.Linq;
using System.Threading.Tasks;

namespace FacturasProductos.Examen.Application.Repositorys
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        void RemoveAsync(TEntity entity);
    }
}