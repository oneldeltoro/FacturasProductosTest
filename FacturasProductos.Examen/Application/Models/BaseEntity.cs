namespace FacturasProductos.Examen.Application.Models
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }

        protected BaseEntity(int id)
        {
            Id = id;
        }
    }
}