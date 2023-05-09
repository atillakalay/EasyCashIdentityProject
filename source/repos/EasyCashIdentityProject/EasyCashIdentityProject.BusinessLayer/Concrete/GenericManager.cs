using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Add(TEntity entity)
        {
            _genericDal.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _genericDal.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _genericDal.Delete(entity);
        }

        public TEntity GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public List<TEntity> GetAll()
        {
            return _genericDal.GetAll();
        }
    }
}