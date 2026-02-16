
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo{get;set;}
        public string IMEI {get;set;}
        public int Memoria{get;set;}

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
             Modelo = Modelo;
                IMEI = IMEI;
                Memoria = Memoria;

                //na hora de instanciar o nokia, tem que passar os parametros do construtor, e ai sim, passar para as propriedades.  
        }

        private void InstalarAplicativo()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para o número {Numero} ... ");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}