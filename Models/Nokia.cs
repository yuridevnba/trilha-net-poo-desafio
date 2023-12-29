namespace DesafioPOO.Models
{
    //Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){ }
        
        //Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){

          Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no Nokia");
        
        }

    }
}