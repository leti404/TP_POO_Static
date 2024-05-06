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
            DicClientes.Keys.Count;
        } 
        public  static int AgregarCliente(Cliente)
        {
           
        } 
        public static Cliente BuscarCliente(int id)
        {
           
        } 
        public static int CambiarEntrada(int id, int tipo, int cantidad)
        {
           
        } 
        public  static List<string> EstadisticasTiquetera()
        {
           
        } 
   
}