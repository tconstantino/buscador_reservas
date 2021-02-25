using BuscadorReserva.ConsoleApp.Enumeration;
using System;
using System.Linq;

namespace BuscadorReserva.ConsoleApp.Service
{
    public class VerificadorTipoDiaService
    {
        private String[] DiasSemana = { "mon", "tue", "wed", "thu", "fri" };
        private String[] FinalSemana = { "sat", "sun" };
        public TipoDiaSemanaEnum VerificarTipoDia(String data)
        {
            String dia = data.Substring(10, 3);

            if (this.DiasSemana.Contains(dia)) return TipoDiaSemanaEnum.DiaSemana;
            else if (this.FinalSemana.Contains(dia)) return TipoDiaSemanaEnum.FinalSemana;
            else throw new Exception($"Dia {dia} inexistente!");
        }
    }
}
