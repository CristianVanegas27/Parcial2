namespace Dominio
{
    public class Pedido
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int [] ListaProductos { get; set; }
        public string DireccionOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public string EstadoPedido { get; set; }

        public int Idvehiculo { get; set; }

        public int Idconductor { get; set; }




    }
}
