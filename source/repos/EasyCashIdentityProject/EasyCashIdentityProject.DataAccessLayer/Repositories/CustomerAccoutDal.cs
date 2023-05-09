using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.EntityLayer.Concrete;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class CustomerAccoutDal : GenericDal<CustomerAccount>
    {
        public CustomerAccoutDal(Context context) : base(context)
        {
        }
    }
}
