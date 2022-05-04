using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace e_Agenda2._0.Dominio.Contato
{
    [Serializable]
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
     
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Empresa = empresa;
            this.Cargo = cargo;
        }
         public Contato(string nome, string email, string telefone)
         {
          this.Nome = nome;
          this.Email = email;
          this.Telefone = telefone;
         }
        public Contato()
        {
        }
        public override string ToString()
        {       
               return
              "\tNome: " + Nome +
              "\tEmail: " + Email +
              "\tTelefone: " + Telefone +
              "\tEmpresa: " + Empresa +
              "\tCargo: " + Cargo;
         
        }
        private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        {
            bool emailEstaValido = validacaoSelecionada();

            return emailEstaValido;
        }
    }

}
