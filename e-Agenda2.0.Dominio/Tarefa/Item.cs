using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.Tarefa
{
    public class Item
    {

        public string Titulo { get; set; }

        public bool Concluido { get; set; }
        public bool EstaPendente { get; set; }
        public object Descricao { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
