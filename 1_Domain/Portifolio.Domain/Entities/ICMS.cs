using Portifolio.Domain.Interfaces;

namespace Portifolio.Domain.Entities
{
    public class ICMS : IImposto
    {
        public double Juros
        {
            get { return 0.1; }
        }

        public double Calcular(double bruto)
        {
            return Juros * bruto;
        }
    }
}
