using System;

namespace AbstractFactory
{
    public abstract class PassagemOnibusInterEstadual
    {
        public PassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida)
        {
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
        }

        public string Origem { get; private set; }
        public string Destino { get; private set; }
        public DateTime DataHoraPartida { get; private set; }
    }
}