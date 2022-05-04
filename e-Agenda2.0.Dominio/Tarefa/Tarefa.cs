using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.Tarefa
{
    public class Tarefa 
    {
        private List<Item> itens = new List<Item>();

        public PrioridadeTarefa Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Titulo { get; set; }
        public int Numero { get; set; }
        public List<Item> Itens { get { return itens; } }
        public DateTime? DataConclusao { get; set; }
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }
        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return "\tNúmero: " + Numero +
                    "\t Título: " + Titulo +
                    "\t Percentual: " + percentual +
                    "\t Data de Criação: " + DataCriacao +
                    "\t Prioridade: " + Prioridade +
                    "\t Data de conclusão: " + DataConclusao.Value.ToShortDateString() + "\n";
            }

            return "\t Número: " + Numero +
                "\t Título: " + Titulo +
                "\t Percentual: " + percentual +
                "\t Data de criação: " + DataCriacao +
                "\t Prioridade: " + Prioridade + "\n";
        }
        public void AdicionarItem(Item item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
    }
}

