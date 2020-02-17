using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace friends_db_service.Models
{
    public partial class FriendsdatadbContext : DbContext
    {
        public FriendsdatadbContext(DbContextOptions<FriendsdatadbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> users { get; set; }

        public virtual DbSet<Friends> friends { get; set; }

        public virtual DbSet<Sharedproducts> sharedproducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
