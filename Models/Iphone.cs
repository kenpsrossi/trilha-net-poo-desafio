namespace DesafioPOO.Models // Lógica: Define o namespace para a classe Iphone no contexto do projeto DesafioPOO.Models.
{
    public class Iphone : Smartphone // Entrada: Declaração da classe Iphone. Lógica: Define a classe Iphone que herda da classe base Smartphone.
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) // Entrada: Parâmetros do construtor Lógica: Construtor da classe Iphone que repassa os parâmetros para o construtor da classe base Smartphone usando base.
        {
        }
        public override void InstalarAplicativo(string nomeApp) // Entrada: Parâmetro do método (nomeApp).Lógica: Declaração do método InstalarAplicativo, sobrescrito da classe base Smartphone.
        { 
            Console.WriteLine($"Instalando {nomeApp} no iPhone..."); // Entrada: Valor da variável nomeApp. Saída: Mensagem formatada na console. Lógica: Imprime uma mensagem indicando que um aplicativo está sendo instalado no iPhone, incluindo o nome do aplicativo fornecido como argumento.
        }
    }
}