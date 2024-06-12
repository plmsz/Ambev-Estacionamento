﻿namespace Modulo1.Console.Entidades
{
    internal class Ticket
    {
        private long numId = 0;
        public long Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime? DataHoraSaida { get; set; }
        public Usuario Usuario { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacao { get; set; }
        public StatusTicket StatusTicket { get; set; }

        public void CriarTicket(Veiculo veiculo, DateTime dataHoraEntrada, Usuario usuario)
        {
            Id = numId++;
            Veiculo = veiculo;
            DataHoraEntrada = dataHoraEntrada;
            Usuario = usuario;
            StatusTicket = StatusTicket.Aberto;
        }
    }
}