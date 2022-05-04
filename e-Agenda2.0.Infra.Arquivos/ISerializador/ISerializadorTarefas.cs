using e_Agenda2._0.Dominio.Tarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Infra.Arquivos.ISerializador
{
    public interface ISerializadorTarefas
    {
        List<Tarefa> CarregarTarefasDoArquivo();
        void GravarTarefasEmArquivo(List<Tarefa> tarefas);

    }
}
