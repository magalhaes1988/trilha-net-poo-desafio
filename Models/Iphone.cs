namespace DesafioPOO.Models

{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria)
        {   
            this.Numero = numero;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {nomeApp}");
        }
    }
}