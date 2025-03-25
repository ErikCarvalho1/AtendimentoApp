using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoApp
{
    public class ControleFila
    {
        private Queue<int> filaAtendimento;
        private int proximoNumeroGeraar = 1;
        public ControleFila()
        {
            filaAtendimento = new Queue<int>();
        }
        public int GerarSenha()
        {
            filaAtendimento.Enqueue(proximoNumeroGeraar);
            Console.WriteLine("senha gerada");//imprimir
            return proximoNumeroGeraar++;
        }
        public void ChamarProximo()
        {
            var proximoDaFila = filaAtendimento.Dequeue();
            Console.WriteLine($"Próxima senha:  {proximoDaFila}");

        }
        public void MostrarFila()
        {
            Console.WriteLine("-------------");
            Console.Write("Senhas da Fila: ");
            foreach (var senha in filaAtendimento)
            {
                Console.Write(senha + " - ");
            }


        }
        public void ReiniciarFila()
        {
            filaAtendimento.Clear();
        }
     }
}
