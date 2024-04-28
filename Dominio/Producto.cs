using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Producto
    {
        [Key]
        public  int Codigo { get; set; }
        public required string Descripcion { get; set; }
        public required string Marca { get; set; }
        public required string Categoria { get; set; }
        public required string Estado { get; set; }
    }
}
