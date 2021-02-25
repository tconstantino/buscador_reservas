using BuscadorReserva.ConsoleApp.DAO;
using BuscadorReserva.ConsoleApp.Enumeration;
using BuscadorReserva.ConsoleApp.Service;
using NUnit.Framework;
using System;

namespace BuscadorReserva.Test.Service
{
    public class BuscadorReservaServiceTest
    {
        private ReservaDAO ReservaDAO;
        [SetUp]
        public void Setup()
        {
            this.ReservaDAO = new ReservaDAO();
        }

        [Test]
        public void DeveRetornarParqueDasFlores()
        {
            TipoClienteEnum tipoClienteEnum = TipoClienteEnum.Regular;
            String[] datas = { "16Mar2020(mon)", "17Mar2020(tue)", "18Mar2020(wed)" };

            BuscadorReservaService buscadorReservaService = new BuscadorReservaService(this.ReservaDAO);

            String saida = buscadorReservaService.BuscadorMelhorReserva(tipoClienteEnum, datas);
            Assert.AreEqual("Parque das flores", saida);
        }

        [Test]
        public void DeveRetornarJardimBotanico()
        {
            TipoClienteEnum tipoClienteEnum = TipoClienteEnum.Regular;
            String[] datas = { "20Mar2020(fri)", "21Mar2020(sat)", "22Mar2020(sun)" };

            BuscadorReservaService buscadorReservaService = new BuscadorReservaService(this.ReservaDAO);

            String saida = buscadorReservaService.BuscadorMelhorReserva(tipoClienteEnum, datas);
            Assert.AreEqual("Jardim Botânico", saida);
        }

        [Test]
        public void DeveRetornarMarAtlantico()
        {
            TipoClienteEnum tipoClienteEnum = TipoClienteEnum.Fidelidade;
            String[] datas = { "26Mar2020(thu)", "27Mar2020(fri)", "28Mar2020(sat)" };

            BuscadorReservaService buscadorReservaService = new BuscadorReservaService(this.ReservaDAO);

            String saida = buscadorReservaService.BuscadorMelhorReserva(tipoClienteEnum, datas);
            Assert.AreEqual("Mar Atlântico", saida);
        }
    }
}
