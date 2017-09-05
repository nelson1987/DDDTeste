using Portifolio.Domain.Interfaces;

namespace Portifolio.Domain.Entities
{
    public class ISS : IImposto
    {
        public double Juros
        {
            get { return 0.05; }
        }

        public double Calcular(double bruto)
        {
            return Juros * bruto;
        }
    }
}
