using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RevisaoP1.Dominio;

namespace RevisaoP1.Repositorio
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
