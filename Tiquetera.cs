static class Tiquetera 
{
        private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente> ();
        private static double E1 = 45000;
        private static double E2 = 60000;
        private static double E3 = 30000;
        private static double E4 = 100000;
        public static int UltimoIDEntrada { get; private set; } 
        
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
            double ImporteAnterior, importeActual, precio;
            bool existe = dicClientes.ContainsKey(id), cambio = false;
            if(existe)
            {
                precio = CalcularPrecio(E1, E2, E3, E4, tipo);
                importeActual = precio * cantidad;
                precio = CalcularPrecio(E1, E2, E3, E4, dicClientes[id].tipo);
                ImporteAnterior = (dicClientes[id].Cantidad) * precio; 
                cliente = dicClientes[id];
                if(importeActual < ImporteAnterior)
                {
                    dicClientes[id].TipoEntrada = tipo;
                    cambio = true;
                }
            }
            return cambio;
        } 
        public static Dictionary<string>  DicClientes.Keys EstadisticasTiquetera()
        {
           int cantCliE1 = 0, cantCliE2 = 0, cantCliE3 = 0, cantCliE4 = 0;
           foreach (Dictionary<string> in DicClientes)
           {
                if()

           }
           Console.WriteLine("Hay " + DicClientes.Keys.Count + " usuarios");
        } 
        static double CalcularPrecio (double E1, double E2, double E3, double E4 , int tipo)
        {
            double precio;
            switch (tipo)
                {
                    case 1:
                        precio = E1;
                    break;

                    case 2:
                        precio = E2;
                    break;

                    case 3:
                        precio = E3;
                    break;

                    case 4:
                        precio = E4;
                    break;
                }
            return precio;
        } 
}