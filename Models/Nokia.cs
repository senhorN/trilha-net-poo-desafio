namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone //Herdado Smartphone na classe Nokia

    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public void Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalando no Nokia com sucesso!");
        }
    }
}
