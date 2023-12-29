using System.Dynamic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;


        private string Numero
        {
            get => _numero;


            set => _numero = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O Número não pode ser vazia.");
        }

        private string Modelo
        {
            get => _modelo;


            set => _modelo = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O Modelo não pode ser vazia.");
        }


        private string Imei
        {
            get => _imei;


            set => _imei = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O Imei não pode ser vazia.");
        }



        private int Memoria
        {
            get;
            set;
        }



        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;


        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
