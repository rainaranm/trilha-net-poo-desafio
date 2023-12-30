namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void Especificacoes(){
            Console.WriteLine("\nEspecificações:");
            Console.WriteLine($"- Número atual: {Numero}");
            Console.WriteLine($"- Modelo: {Modelo}");
            Console.WriteLine($"- IMEI: {IMEI}");
            Console.WriteLine($"- Amarzenamento: {Memoria} GB");
        }

        public void MudarNumero(string numeroNovo)
        {
            Numero = numeroNovo;
            Console.WriteLine($"Número mudado para {Numero}");
        }
        
    }

}