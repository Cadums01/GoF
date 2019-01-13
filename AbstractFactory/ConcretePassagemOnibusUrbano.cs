using System;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusUrbano : PassagemOnibusUrbano
    {
        public ConcretePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string ToString()
        {
            return
                $"Passagem de ônibus Inter Urbano: {Origem} Para: {Destino} Data/hora {DataHoraPartida.ToString("dd/MM/yyyy")}";
        }
    }
}