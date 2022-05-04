using e_Agenda2._0.Dominio.Compromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Infra.Arquivos.ISerializador
{
    public interface ISerializadorCompromissos
    {
        List<Compromisso> CarregarCompromissosDoArquivo();
        void GravarCompromissosEmArquivo(List<Compromisso> compromissos);
    }
}
