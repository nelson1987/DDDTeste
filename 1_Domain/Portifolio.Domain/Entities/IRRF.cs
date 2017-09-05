using Portifolio.Domain.Interfaces;

namespace Portifolio.Domain.Entities
{
    public class IRRF : IImposto
    {
        public double Juros
        {
            get { return 0.25; }
        }

        public double Calcular(double bruto)
        {
            return Juros * bruto;
        }
    }
}
