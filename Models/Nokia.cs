using System; // Lógica: Importa o namespace System para utilizar funcionalidades básicas do C#.
using DesafioPOO.Models; // Lógica: Importa o namespace DesafioPOO.Models para usar a classe base Smartphone.
namespace PhonePooProject.Models // Lógica: Define um namespace para a classe Flip no contexto do projeto PhonePooProject.
{
    public class Flip : Smartphone // Lógica: Define a classe Flip que herda da classe base Smartphone.
    {
        public Flip(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) // Lógica: Construtor da classe Flip que repassa os parâmetros para o construtor da classe base Smartphone usando base.
        {
        }
        public override void InstalarAplicativo(string nomeApp) //Entrada: Parâmetro do método (nomeApp).Lógica: Declaração do método InstalarAplicativo, sobrescrito da classe base Smartphone.
        {
            Console.WriteLine($"Instalando {nomeApp} no Flip."); // Entrada: Valor da variável nomeApp. Saída: Mensagem formatada na console. Lógica: Imprime uma mensagem indicando que um aplicativo está sendo instalado no Flip, incluindo o nome do aplicativo fornecido como argumento.
        }
    }
}