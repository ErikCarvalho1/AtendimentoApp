namespace AtendimentoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ControleFila fila = new ControleFila();

            fila.GerarSenha();
            fila.GerarSenha();
            fila.MostrarFila();
            fila.ChamarProximo();

            fila.MostrarFila();
            

            Console.ReadKey();

        }
    }
}
