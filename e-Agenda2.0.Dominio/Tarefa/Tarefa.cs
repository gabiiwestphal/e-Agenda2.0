using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.Compartilhado;

namespace e_Agenda2._0.Dominio.Tarefa
{
    public class Tarefa : EntidadeBase
    {
        private List<Item> itens = new List<Item>();

        private int prioridade;
        public string Descricao;
        private Status statusTarefa;

        public DateTime DataCriacao { get; set; }
        public string Titulo { get; set; }
        public int Numero { get; set; }
        public List<Item> Itens { get { return itens; } }
        public DateTime? DataConclusao { get; set; }
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string descricao, string prioridade) : this()
        {
            Numero = n;
            Titulo = descricao;
            DataConclusao = null;
            PrioridadeTarefa = prioridade;
        }
        public Status StatusTarefa
        {
            get
            {
                return CalcularPercentualConcluido() == 100 ? Status.concluido : Status.pendente;

            }
            set { statusTarefa = value; }
        }
        public string PrioridadeTarefa
        {
            get
            {
                string retorno = "";
                if (prioridade == 1)
                    retorno = "Baixa";
                else if (prioridade == 2)
                    retorno = "Normal";
                else if (prioridade == 3)
                    retorno = "Alta";

                return retorno;
            }

            set
            {
                if (value == "Baixa")
                    prioridade = 1;
                else if (value == "Normal")
                    prioridade = 2;
                else if (value == "Alta")
                    prioridade = 3;
            }
        }
        public void AdicionarItem(Item item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }
        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();

        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }
        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine(" - É necessário inserir um título!");

            if (DataCriacao.Date == new DateTime(1, 1, 1))
                sb.AppendLine(" - É necessário inserir uma data de criação!");

            if (prioridade == 0)
                sb.AppendLine(" - É necessário inserir uma prioridade (Alta, Normal ou Baixa)!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

    }
}
