using System.Data.Entity;
namespace ORM.Project
{
   public class ClienteContext: DbContext
    {
     public   DbSet<cliente> Clientes { get; set;}
    }
}
