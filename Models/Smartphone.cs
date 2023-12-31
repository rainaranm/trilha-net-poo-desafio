namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;

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
            Console.WriteLine($"- Modelo: {_modelo}");
            Console.WriteLine($"- IMEI: {_imei}");
            Console.WriteLine($"- Amarzenamento: {_memoria} GB");
        }

        public void MudarNumero(string numeroNovo)
        {
            Numero = numeroNovo;
            Console.WriteLine($"Número mudado para {Numero}");
        }
        
    }

}