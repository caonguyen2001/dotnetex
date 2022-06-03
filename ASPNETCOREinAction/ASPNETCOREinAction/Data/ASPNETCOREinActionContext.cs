using Microsoft.EntityFrameworkCore;
using ASPNETCOREinAction.Models;

namespace ASPNETCOREinAction.Data
{
    public class ASPNETCOREinActionContext : DbContext
    {
        public ASPNETCOREinActionContext(DbContextOptions<ASPNETCOREinActionContext> options)
            : base(options) 
        {
        }
        
        public DbSet<RoomType> RoomType { get; set; }
    }
}
