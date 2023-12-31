namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Modelo {get; set;}
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string modelo, string modelo1)
        {
            //Numero = numero;
            Modelo = modelo;
            //IMEI = imei;
            //Memoria = memoria;

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

   /*     protected Smartphone(string v, string modelo)
        {
            this.v = v;
            Modelo = modelo;
        }
*/
        public abstract void Ligar();

        public abstract void ReceberLigacao(string mensagem);
       

        public abstract void InstalarAplicativo(string nomeApp);
    }
}