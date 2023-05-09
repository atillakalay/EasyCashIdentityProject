using EasyCashIdentityProject.DataAccessLayer.Concrete;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class CustomerAccountProcessDal : GenericDal<CustomerAccountProcessDal>
    {
        public CustomerAccountProcessDal(Context context) : base(context)
        {
        }
    }
}
