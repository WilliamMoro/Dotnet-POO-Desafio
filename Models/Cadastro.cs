namespace DesafioPOO.Models
{
    public class Cadastro
    {
        List<Iphone> celularesIphone = new List<Iphone>();
        List<Nokia> celularesNokia = new List<Nokia>();

        public void InserirDados(string tipoCase)
        {
            Console.WriteLine("Digite o número do celular");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite o modelo do celular");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o IMEI do celular");
            string imei = Console.ReadLine();
            Console.WriteLine("Digite o Armazenamento do celular");
            int memoria = Convert.ToInt32(Console.ReadLine());

            if (tipoCase == "1")
            {
                CadastrarIphone(numero, modelo, imei, memoria);
            }
            else
            {
                CadastrarNokia(numero, modelo, imei, memoria);
            }
        }

        public Iphone CadastrarIphone(string numero, string modelo, string imei, int memoria)
        {
            var iphone = new Iphone(numero, modelo, imei, memoria);

            Console.Clear();
            CadastradoComSucesso(numero, modelo, imei, memoria);

            Console.WriteLine("");

            iphone.Ligar();

            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("Digite qual aplicativo deseja instalar");
            string app = Console.ReadLine();
            iphone.InstalarAplicativo(app);

            Console.WriteLine("");

            celularesIphone.Add(iphone);
            return iphone;
        }

        public Nokia CadastrarNokia(string numero, string modelo, string imei, int memoria)
        {
            var nokia = new Nokia(numero, modelo, imei, memoria);

            Console.Clear();
            CadastradoComSucesso(numero, modelo, imei, memoria);

            Console.WriteLine("");

            nokia.Ligar();

            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("Digite qual aplicativo deseja instalar");
            string app = Console.ReadLine();
            nokia.InstalarAplicativo(app);

            Console.WriteLine("");

            celularesNokia.Add(nokia);
            return nokia;
        }

        public void CelularesIphoneCadastrados()
        {
            Console.WriteLine($"Esses são os celulares cadastrados:");
            foreach (var iphone in celularesIphone)
            {
                iphone.ApresentarCaracteristicas();
            }
        }

        public void CelularesNokiaCadastrados()
        {
            Console.WriteLine($"Esses são os celulares cadastrados:");
            foreach (var nokia in celularesNokia)
            {
                nokia.ApresentarCaracteristicas();
            }
        }

        public void CadastradoComSucesso(string numero, string modelo, string imei, int memoria)
        {
            Console.WriteLine($"{numero}");
            Console.WriteLine($"{modelo}");
            Console.WriteLine($"{imei}");
            Console.WriteLine($"{memoria}");
        }

    }
}
