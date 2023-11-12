using System;

namespace Gestor_de_Clínica_Veterinária
{
    public class Pessoa
    {
        protected string nome;
        protected string telefone;
        public Pessoa(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public string getnome()
        {
            return nome;
        }
        public void settelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string gettelefone()
        {
            return telefone;
        }
    }
}
