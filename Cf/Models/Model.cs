using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cf.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<People> People { get; set; }
        public DbSet<House> House { get; set; }

    }
        public class People
    {
            public  int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Identification { get; set; }
            //Creando un FK indicando que una persona puede tener muchas casas 
            public ICollection<House> Houses { get; set; }

    }

    public class House
    {
            public  int Id { get; set; }
            //Nuvo campo agregado
            public string Country { get; set; }
            public  string Address { get; set; }
            /**********************************************Generando FK***********************************************************************************/
            // Al reves para saber que casa es la persona dueña
            public int PeopleId { get; set; }
            // Para tener una referencia a nivel de objeto
            public People People { get; set; }
            /*********************************************************************************************************************************/

    }

    
}
