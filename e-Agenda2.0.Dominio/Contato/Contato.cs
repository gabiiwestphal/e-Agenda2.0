using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.Compartilhado;

namespace e_Agenda2._0.Dominio.Contato
{
    public class Contato : EntidadeBase
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato()
        {
        }

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
        public override string ToString()
        {
            string
                retorno =
              "\tNome: " + Nome +
              "\tEmail: " + Email +
              "\tTelefone: " + Telefone +
              "\tEmpresa: " + Empresa +
              "\tCargo: " + Cargo;

            return retorno;
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();
            string mensagem = "";

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine(" - Nome Inválido!");

            if (ValidarEmail(Email) == false)
                mensagem += " - Email Inválido";

            if (ValidarTelefone(Telefone) == false)
                mensagem += " - Telefone Inválido";

            if (mensagem != "")
                return mensagem;

            return "REGISTRO_VALIDO";
        }

        private bool ValidarTelefone(string telefone)
        {
            if (Telefone.Length < 14)
                return false;

            return true;
        }

        private bool ValidarEmail(string email)
        {
            int indexArr = email.IndexOf("@");
            bool EmailValido = false;

            if (indexArr > 0)
                EmailValido = true;

            return EmailValido;
        }
    }

}
