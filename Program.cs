using System;
internal class Program
{
    Cliente cliente1 = null;
    static void Main(string[] args)
    {
        const int OP1 = 1, OP2 = 2, OP3 = 3, OP4 = 4, OP5 = 5;
        int opcion, id = 0;
        double importeAbonado;
        
        do
        {
            opcion = IngresarEnteroConParametros("1. Nueva Inscripción, 2. Obtener Estadísticas del Evento, 3. Buscar Cliente, 4. Cambiar entrada de un Cliente, 5.Salir", OP1, OP5);
            switch (opcion)
            {
                case OP1:
                    id = Tiquetera.AgregarCliente(cliente, id);
                    id++;
                break;
                case OP2:
                break;
                case OP3:
                break;
                case OP4:
                break;
            }

        }while(opcion != OP5);

    }
    static int IngresarEnteroConParametros(string mensaje, int max, int min)
    {
        int numero;
        Console.WriteLine(mensaje);
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= max && numero > min)
        {
            Console.WriteLine("Error, ingrese un número válido");
        }
        return numero;
    }
    static string IngresoCadena(string mensaje)
    {
        string cadena;
        Console.WriteLine(mensaje);
        do 
        {
            cadena = Console.ReadLine();
        }while(cadena == null);
        return cadena;
    }
    static Cliente ObtenerCliente()
    {
        string nombre = IngresoCadena("Ingrese el nombre");
        string apellido= IngresoCadena("Ingrese el Apellido");
        int dni = IngresarEnteroConParametros("Ingrese el DNI", 100000000, 0);
        int tipoEntrada = IngresarEnteroConParametros("Ingrese el tipo de entrada", 4, 0);
        Date fechaInscripcion = date.Today;
        Cliente cliente1 = new Cliente(nombre, apellido, dni, int tipoEntrada, Date fechaInscripcion );
        return cliente1;
    }
   


}
