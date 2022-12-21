namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //IMPLEMENTADO
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                Console.WriteLine("Hospedes incluidos");
            }
            else
            {
               //IMPLEMENTADO.
                throw new Exception ("O numero de hospedes é maior do que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //IMPLEMENTADO
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal()
        {
            //IMPLEMENTADO
            decimal valor = DiasReservados * Suite.ValorDiaria;

            return valor;
        }
    }
}