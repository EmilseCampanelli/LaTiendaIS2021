namespace LaTiendaIS2021.Dominio.Modelo
{
    public class LineaVenta
    {
        public int id { get; set; }
        public int? cantidad { get; set; }


        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public int TalleId { get; set; }
        public int ColorId { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual Talle Talle { get; set; }
        public virtual Color Color { get; set; }
        public decimal? precio { get => cantidad * Producto.PrecioVenta; set => value = cantidad * Producto.PrecioVenta; }
        public bool CantidadProducto()
        {
            if (cantidad > 0)
            {
                return true;
            }
            else return false;
        }

        public decimal? CalcularSubtotal()
        {
            return cantidad * Producto.PrecioVenta;

        }


    }
}
