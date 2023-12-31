namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string modelo) : base("Apple",  modelo)
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
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando app no Iphone");
            
        }

        internal void InstalarAplicativo()
        {
            throw new NotImplementedException();
        }
    }
}