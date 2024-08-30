using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
