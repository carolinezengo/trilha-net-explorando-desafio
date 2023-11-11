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
            

            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
               
            }
            else
            {
                // IMPLEMENTADO

                throw new Exception("A quantidade de hóspede não pode exceder a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public int ObterQuantidadeHospedes()
        {

            int quantidade = Hospedes.Count;
            
            // IMPLEMENTADO
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            //IMPLEMENTADO *
           
            decimal valor = 0, desconto = 10; 
           
            valor = DiasReservados * Suite.ValorDiaria;

            // IMPLEMTADO
            if (DiasReservados >= 10 )
            {
                 
                valor = valor - ( desconto /100) * valor;
                return valor;
                
            }
            
             return valor;
            

            
        }
    }
}