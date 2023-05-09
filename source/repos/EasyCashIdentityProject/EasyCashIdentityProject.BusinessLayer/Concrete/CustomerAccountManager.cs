using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : GenericManager<CustomerAccount>
    {
        public CustomerAccountManager(IGenericDal<CustomerAccount> genericDal) : base(genericDal)
        {
        }
    }
}
