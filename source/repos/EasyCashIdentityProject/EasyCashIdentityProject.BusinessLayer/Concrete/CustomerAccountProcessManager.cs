using EasyCashIdentityProject.DataAccessLayer.Abstract;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : GenericManager<CustomerAccountProcessManager>
    {
        public CustomerAccountProcessManager(IGenericDal<CustomerAccountProcessManager> genericDal) : base(genericDal)
        {
        }
    }
}
