using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions <CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
