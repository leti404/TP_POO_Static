static class Tiquetera {
        private Dictionary<int, Cliente> DicClientes { get; private set; }
        public int UltimoIDEntrada { get; private set; } 
        public Tiquetera(Dictionary<int, Cliente> dicClientes, int ultimoIDEntrada) 
        {
           DicClientes = dicClientes;
           UltimoIDEntrada = ultimoIDEntrada;
        }
        
        static public int DevolverUltimoID()
        {
           
        } 
        static public int AgregarCliente(Cliente)
        {
           
        } 
        static public Cliente BuscarCliente(int id)
        {
           
        } 
        static public int CambiarEntrada(int id, int tipo, int cantidad)
        {
           
        } 
        static public List<string> EstadisticasTiquetera()
        {
           
        } 
   
}