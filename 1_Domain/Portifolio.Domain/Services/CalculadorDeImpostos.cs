using Portifolio.Domain.Entities;
using Portifolio.Domain.Interfaces;

namespace Portifolio.Domain.Services
{
    public class CalculadorDeImpostos
    {
        private Orcamento _orcamento { get; set; }

        public CalculadorDeImpostos(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public double RealizarCalculo(IImposto imposto)
        {
            return imposto.Calcular(_orcamento.Valor);
        }

    }
}
