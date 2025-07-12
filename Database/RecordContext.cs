using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UsersAPI.Models;

namespace UsersAPI.Database
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options) { }

        public DbSet<Record> Records { get; set; } = null!;
    }
}
