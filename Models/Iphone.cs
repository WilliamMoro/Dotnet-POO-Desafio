namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"iPhone instalando o aplicativo {nomeApp}");
        }

        public void ApresentarCaracteristicas()
        {
            Console.WriteLine($"O número do seu Iphone é: {Numero}, {Modelo}, e com IMEI de rastreio ({IMEI}, com {Memoria} de armazenamento!)");
        }
    }
}