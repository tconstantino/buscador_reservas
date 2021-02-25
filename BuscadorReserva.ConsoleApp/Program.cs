using BuscadorReserva.ConsoleApp.DAO;
using BuscadorReserva.ConsoleApp.Enumeration;
using BuscadorReserva.ConsoleApp.Service;
using System;
using System.Linq;

namespace BuscadorReserva.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular sua melhor reserva!");
            Console.ReadKey();
            Console.WriteLine("Existem 2 tipos de clientes: Regular e Fidelidade");
            Console.ReadKey();
            Console.WriteLine("Insira os dados no formato: <tipo_do_cliente>: <data1>, <data2>, <data3>, …");
            Console.WriteLine("Exemplo: Regular: 16Mar2020(mon), 17Mar2020(tues), 18Mar2020(wed)");
            String entrada = Console.ReadLine();

            String tipoCliente = entrada.Split(":")[0];
            TipoClienteEnum tipoClienteEnum = Enum.Parse<TipoClienteEnum>(tipoCliente);

            String sequenciaDatas = entrada.Split(":")[1];
            String[] datas = sequenciaDatas.Split(",").Select(d => d.Trim()).ToArray();

            ReservaDAO reservaDAO = new ReservaDAO();
            BuscadorReservaService buscadorReservaService = new BuscadorReservaService(reservaDAO);

            String melhorReserva = buscadorReservaService.BuscadorMelhorReserva(tipoClienteEnum, datas);

            Console.WriteLine("\n\nSua melhor reserva é:\n");
            Console.WriteLine($"***{melhorReserva}***\n\n\n\n\n\n");
        }
    }
}
