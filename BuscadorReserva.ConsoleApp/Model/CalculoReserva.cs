using System;

namespace BuscadorReserva.ConsoleApp.Model
{
    class CalculoReserva
    {
        public Decimal Valor { get; set; }
        public String NomeHotel { get; set; }
        public Int16 Classificacao { get; set; }
        public Reserva Reserva { get; set; }
    }
}
