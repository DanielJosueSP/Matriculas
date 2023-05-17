using System.Runtime.Intrinsics.X86;
using System.ComponentModel.DataAnnotations;

namespace Gestion.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? NombreAlumno { get; set; }
        [Required]
        [Range(0,20)]
        public int Nota1{ get; set; }
        [Required]
        [Range(0,20)]
        public int Nota2{ get; set; }
        [Required]
        [Range(0,20)]
        public int Nota3{ get; set; }
        [Required]
        [Range(0,20)]

        public float Promedio{ get; set; }

        public void calcularPromedio(){
            Promedio = (float)((Nota1+Nota2+Nota3)/3.0);
            Promedio = (float)Math.Round(Promedio);
        }

    }
}