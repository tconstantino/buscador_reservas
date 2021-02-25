using BuscadorReserva.ConsoleApp.Model;
using System.Collections.Generic;

namespace BuscadorReserva.ConsoleApp.DAO
{
    public class ReservaDAO
    {
        private static IList<Reserva> Reservas = new List<Reserva>()
        {
            new Reserva()
            {
                NomeHotel = "Parque das flores",
                Classificacao = 3,
                ValorDiaSemanaRegular = 110,
                ValorDiaSemanaFidelidade = 80,
                ValorFinalSemanaRegular = 90,
                ValorFinalSemanaFidelidade = 80
            },
            new Reserva()
            {
                NomeHotel = "Jardim Botânico",
                Classificacao = 4,
                ValorDiaSemanaRegular = 160,
                ValorDiaSemanaFidelidade = 110,
                ValorFinalSemanaRegular = 60,
                ValorFinalSemanaFidelidade = 50
            },
            new Reserva()
            {
                NomeHotel = "Mar Atlântico",
                Classificacao = 5,
                ValorDiaSemanaRegular = 220,
                ValorDiaSemanaFidelidade = 100,
                ValorFinalSemanaRegular = 150,
                ValorFinalSemanaFidelidade = 40
            },
        };

        public IList<Reserva> ObterReservas()
        {
            return ReservaDAO.Reservas;
        }
    }
}
