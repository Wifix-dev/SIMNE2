namespace SIMNE2.Models
{
    public class Producto
    {
        public int Id { get; set;}
        public string Nombre { get; set;}
        public string Descripcion {get; set;}
        public decimal Precio {get; set;}
        public int Cantidad {get; set;}
        public DateTime FechaAlta {get; set;}
        public bool Activo {get; set;}

    }
}