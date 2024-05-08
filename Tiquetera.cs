static class Tiquetera 
{
        private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente> ();
        public int UltimoIDEntrada { get; private set; } 
        public Tiquetera(Dictionary<int, Cliente> dicClientes, int ultimoIDEntrada) 
        {
           DicClientes = dicClientes;
           UltimoIDEntrada = ultimoIDEntrada;
        }
        
        public static int DevolverUltimoID()
        {
            return ultimoIDEntrada;
        } 
        public  static int AgregarCliente(Cliente cliente, int id)
        {
            cliente = ObtenerCliente();
            Console.WriteLine($"Se ha creado el cliente {cliente.Nombre}");
            DicClientes.Add(id, cliente)
            return id;
        } 
        public static Cliente BuscarCliente(int id)
        {
           bool existe = dicClientes.ContainsKey(id);
           if(existe)
           {

           }
        } 
        public static int CambiarEntrada(int id, int tipo, int cantidad)
        {
           
        } 
        public  static List<string> EstadisticasTiquetera()
        {
           
        } 
   
}