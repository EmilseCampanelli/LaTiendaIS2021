namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Empleado
    {
        public int Id
        {
            get; set;
        }
        public int? Dni
        {
            get; set;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }

        public int UsuarioId { get; set; }
        public int TipoEmpleadoId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TipoEmpleado TipoEmpleado { get; set; }

    }
}
