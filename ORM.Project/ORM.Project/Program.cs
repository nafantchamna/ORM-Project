using System.Linq;

namespace ORM.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ClienteContext())
            {   
                var quantidade_clientes = context.Clientes.Count();
                context.Clientes.Add(new cliente() { Nome = "CLETCHE", Telefone = "11987949330" });
                context.SaveChanges();
            }
        }
    }
}
