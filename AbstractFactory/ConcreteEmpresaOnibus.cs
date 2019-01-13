using System;

namespace AbstractFactory
{
    public class ConcreteEmpresaOnibus : EmpresaOnibus
    {
        /// <summary>
        /// Emite passagem de onibus urbano
        /// </summary>
        /// <param name="origem">Origem</param>
        /// <param name="destino">Destino</param>
        /// <param name="dataHoraPartida">Data hora partida</param>
        /// <returns><see cref="PassagemOnibusUrbano"/></returns>
        public override PassagemOnibusUrbano EmitePassagemOnibusUrbano(string origem, string destino,
            DateTime dataHoraPartida)
        {
            return new ConcretePassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }

        /// <summary>
        /// Emite passagem de onibus inter estadual
        /// </summary>
        /// <param name="origem">Origem</param>
        /// <param name="destino">Destino</param>
        /// <param name="dataHoraPartida">Data hora partida</param>
        /// <returns><see cref="PassagemOnibusInterEstadual"/></returns>
        public override PassagemOnibusInterEstadual EmitePassagemOnibusInterEstadual(string origem, string destino,
            DateTime dataHoraPartida)
        {
            return  new ConcretePassagemOnibusInterEstadual(origem,destino,dataHoraPartida);
        }
    }
}