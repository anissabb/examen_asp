namespace Common.Repository
{
    public interface IUpdateRepository<TEntity, TId>
    {
        bool Update(TId id, TEntity entity);
    }
}