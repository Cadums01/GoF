using System;

namespace FactoryMethod
{
    public class MyFactoryMethod
    {
        private readonly Empresa _viacaoAbcLocal;
        private readonly Empresa _viacaoXyzInter;
        
        public MyFactoryMethod()
        {
            _viacaoAbcLocal = new EmpresaOnibusUrbano();
            _viacaoXyzInter = new EmpresaOnibusInterEstadual();
        }

        /// <summary>
        /// Emite passagem de Onibus Urbano
        /// </summary>
        /// <returns>Passagem</returns>
        public Passagem CriarPassagemUrbano()
        {
            var pUrbano =
                _viacaoAbcLocal.EmitePassagem("São Bernardo", "Santo André", new DateTime(2018, 12, 10, 22, 10, 00));

            return pUrbano;
        }

        /// <summary>
        /// Emite passagem Onibus Inter Estadual
        /// </summary>
        /// <returns>Passagem</returns>
        public Passagem CriarPassagemOnibusInter()
        {
            var pInter =
                _viacaoXyzInter.EmitePassagem("São Paulo", "Rio de Janeiro", new DateTime(2018, 12, 10, 22, 10, 00));
            return pInter;
        }
        
    }
}