static class Tiquetera 
{
        private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente> ();
        private static double E1;
        private static double E2;
        private static double E3;
        private static double E4;
        public static int UltimoIDEntrada { get; private set; } 
        public static Tiquetera(Dictionary<int, Cliente> dicClientes, int ultimoIDEntrada) 
        {
           DicClientes = dicClientes;
           UltimoIDEntrada = ultimoIDEntrada;
           E1 = 45000;
           E2 = 60000;
           E3 = 30000;
           E4 = 100000;
        }
        
        public static int DevolverUltimoID()
        {
            return ultimoIDEntrada;
        } 
        public  static int AgregarCliente(Cliente cliente, int id)
        {
            cliente = ObtenerCliente();
            Console.WriteLine($"Se ha creado el cliente {cliente.Nombre}");
            DicClientes.Add(id, cliente);
            UltimoIDEntrada = id;
            return id;
        } 
        public static Cliente BuscarCliente(int id)
        {
            Cliente cliente;
            bool existe = dicClientes.ContainsKey(id);
            if(existe)
            {
                cliente = dicClientes[id];
            }
            return cliente;
        } 
        public static bool CambiarEntrada(int id, int tipo, int cantidad)
        {
            Cliente cliente;
            double ImporteAnterior = (dicClientes[id].Cantidad) * , importeActual = tipo * cantidad;
            bool existe = dicClientes.ContainsKey(id), cambio = false;
            if(existe)
            {
                cliente = dicClientes[id];
                if(importeActual < ImporteAnterior)
                {
                    dicClientes[id].TipoEntrada = tipo;
                    cambio = true;
                }
            }
            return cambio;
        } 
        public  static List<string> EstadisticasTiquetera()
        {
           
        } 
   
}