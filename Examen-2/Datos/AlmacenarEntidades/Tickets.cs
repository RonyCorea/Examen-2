namespace Datos.AlmacenarEntidades
{
    public class Tickets
    {
        public string Id { get; set; }
        public string Fecha { get; set; }
        public string NombreCliente { get; set; }
        public string TipoSoporte { get; set; }
        public string TipoEquipo { get; set; }
        public string DescripcionProblema { get; set; }
        public double Costo { get; set; }
        public string DescripcionSolucion { get; set; }

       
        public Tickets()
        {
        }

        public Tickets(string id, string fecha, string nombreCliente, string tipoSoporte, string tipoEquipo, string descripcionProblema, double costo, string descripcionSolucion)
        {
            Id = id;
            Fecha = fecha;  
            NombreCliente = nombreCliente;
            TipoSoporte = tipoSoporte;
            TipoEquipo = tipoEquipo;
            DescripcionProblema = descripcionProblema;
            Costo = costo;
            DescripcionSolucion = descripcionSolucion;

        }
    }
}
