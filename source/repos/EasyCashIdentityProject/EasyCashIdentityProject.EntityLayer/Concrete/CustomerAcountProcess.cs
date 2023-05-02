namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAcountProcess
    {
        public int CustomerAccountProcessId { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime PrecessDate { get; set; }
    }
}
