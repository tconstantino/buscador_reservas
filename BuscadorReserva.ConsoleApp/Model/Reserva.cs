using System;

namespace BuscadorReserva.ConsoleApp.Model
{
    public class Reserva
    {
        public String NomeHotel { get; set; }
        public Int16 Classificacao { get; set; }
        public Decimal ValorDiaSemanaRegular { get; set; }
        public Decimal ValorDiaSemanaFidelidade { get; set; }
        public Decimal ValorFinalSemanaRegular { get; set; }
        public Decimal ValorFinalSemanaFidelidade { get; set; }
    }
}
