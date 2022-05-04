using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.Contato
{
    public interface IRepositorioContato
    {
        string Nome { get; }

        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato novoContato);
        List<Contato> SelecionarTodos();
    }
}
