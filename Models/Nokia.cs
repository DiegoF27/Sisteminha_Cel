namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string modelo) : base("BUST", modelo)
        {
        }

        public override void Ligar()
        {
         Console.WriteLine($"Ligando o iPhone {Modelo}");
        }

    // Implementação do método EnviarMensagem específico para iPhone
        public override void ReceberLigacao(string mensagem)
        {
            Console.WriteLine($"Enviando mensagem do iPhone {Modelo}: {mensagem}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {   
            Console.WriteLine("Instalando app no Nokia");
            throw new NotImplementedException();
        }
    }
}