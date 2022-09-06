using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angularWebApi.Model
{
    public class paymentDetailsContext : DbContext
    {
        public paymentDetailsContext(DbContextOptions<paymentDetailsContext> options) : base (options)
        {

        }

        public DbSet<paymentDetails> paymentDetails { get; set; }
    }
}
