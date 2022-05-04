using e_Agenda2._0.Dominio.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Infra.Arquivos.ISerializador
{
    public interface ISerializadorContatos
    {
        List<Contato> CarregarContatosDoArquivo();
        void GravarContatosEmArquivo(List<Contato> contatos);
    }
}
