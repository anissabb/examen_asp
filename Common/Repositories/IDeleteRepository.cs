namespace Common.Repository
{
    public interface IDeleteRepository<TEntity, TId>
    {
        bool Delete(TId id);
    }
}