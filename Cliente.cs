class Cliente {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int DNI { get; private set; } 
        public Date FechaInscripcion { get; set; }
        public int TipoEntrada { get; set; }
        public int Cantidad { get; set; }
        public Cliente(string nombre, string apellido, int dni, Date fechaInscripcion, int TipoEntrada, int cantidad) 
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaInscripcion = fechaInscripcion;
            TipoEntrada = tipoEntrada;
            Camtidad = cantidad;
        }   
}