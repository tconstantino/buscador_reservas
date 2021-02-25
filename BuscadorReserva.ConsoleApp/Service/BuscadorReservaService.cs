using BuscadorReserva.ConsoleApp.DAO;
using BuscadorReserva.ConsoleApp.Enumeration;
using BuscadorReserva.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuscadorReserva.ConsoleApp.Service
{
    public class BuscadorReservaService
    {
        public BuscadorReservaService(ReservaDAO reservaDAO)
        {
            this.ReservaDAO = reservaDAO;
        }
        private ReservaDAO ReservaDAO { get; set; }

        public String BuscadorMelhorReserva(TipoClienteEnum tipoCliente, String[] datas)
        {
            IList<Reserva> reservas = this.ReservaDAO.ObterReservas();
            VerificadorTipoDiaService verificadorTipoDiaService = new VerificadorTipoDiaService();

            IList<CalculoReserva> reservasCalculadas = reservas.Select(r => new CalculoReserva()
            {
                Classificacao = r.Classificacao,
                NomeHotel = r.NomeHotel,
                Reserva = r,
                Valor = 0
            }).ToList();

            foreach (String data in datas)
            {
                TipoDiaSemanaEnum tipoDia = verificadorTipoDiaService.VerificarTipoDia(data);
                Boolean ehFinalSemana = tipoDia == TipoDiaSemanaEnum.FinalSemana;

                foreach(CalculoReserva calculoReserva in reservasCalculadas)
                {
                    if(tipoCliente == TipoClienteEnum.Regular)
                    {
                        calculoReserva.Valor += ehFinalSemana ? calculoReserva.Reserva.ValorFinalSemanaRegular : calculoReserva.Reserva.ValorDiaSemanaRegular;
                    }
                    else
                    {
                        calculoReserva.Valor += ehFinalSemana ? calculoReserva.Reserva.ValorFinalSemanaFidelidade : calculoReserva.Reserva.ValorDiaSemanaFidelidade;
                    }
                }
            }

            CalculoReserva melhorReserva = reservasCalculadas.OrderBy(r => r.Valor).ThenByDescending(r => r.Classificacao).FirstOrDefault();

            return melhorReserva.NomeHotel;
        }
    }
}
