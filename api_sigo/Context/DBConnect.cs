using api_sigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_sigo.Context
{
    public class DBConnect: DbContext
    {

        public DBConnect(DbContextOptions<DBConnect> options)
            : base(options) { }

        public DbSet<LinhaReduzida> view_linhas { get; set; }
        public DbSet<Linha> LinhaIndividual { get; set; }
        public DbSet<Parada> ItinerarioLinha { get; set; }

    }
}
