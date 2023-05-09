namespace EasyCashIdentityProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
