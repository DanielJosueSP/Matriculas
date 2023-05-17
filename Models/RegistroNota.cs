using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gestion.Models
{
    public class RegistroNota : DbContext
    {
        public DbSet<Alumno> Notas { get; set; }

        public RegistroNota(DbContextOptions<RegistroNota> options) : base (options){

        }
    }
}