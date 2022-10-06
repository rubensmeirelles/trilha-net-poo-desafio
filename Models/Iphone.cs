namespace DesafioPOO.Models
{
  // TODO: Herdar da classe "Smartphone"
  public class Iphone : Smartphone
  {
    public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
    {
    }


    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
      System.Console.WriteLine($"Instalando o aplicativo {nomeApp}.");
    }
  }
}