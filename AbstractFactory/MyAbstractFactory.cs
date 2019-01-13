using System;

namespace AbstractFactory
{
    public class MyAbstractFactory
    {
        private EmpresaOnibus _empresaOnibus;

        public MyAbstractFactory()
        {
            _empresaOnibus = new ConcreteEmpresaOnibus();
        }
        
        public PassagemOnibusUrbano CriarPassagemOnibusUrbano()
        {
            return _empresaOnibus.EmitePassagemOnibusUrbano("São Bernardo", "Santo André",
                new DateTime(2018, 12, 10, 22, 10, 00));
        }

        public PassagemOnibusInterEstadual CriarPassagemOnibusInterEstadual()
        {
            return _empresaOnibus.EmitePassagemOnibusInterEstadual("São Paulo", "Rio de Janeiro",
                new DateTime(2018, 12, 10, 22, 10, 00));
        }
    }
}