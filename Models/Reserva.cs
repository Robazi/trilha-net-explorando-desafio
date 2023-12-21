using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {       
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                {
                    throw new ArgumentException("A quantidade de hospedes não pode exceder a capacidade da suíte");
                }                
               
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {            
            decimal valor = DiasReservados * Suite.ValorDiaria; 
            
            if(DiasReservados >= 10)
            {                
                decimal desconto = valor * 0.10M;
                return valor - desconto;
            }
            return valor;
        }
    }
}