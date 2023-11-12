namespace Gestor_de_Clínica_Veterinária
{
    public class Veterinario : Pessoa
    {
        private string num_medico;
        private string tempo_atividade;
        private string especialidade;

        public Veterinario(string num_medico, string tempo_atividade, string especialidade, string nome, string telefone) : base(nome, telefone)
        {
            this.num_medico = num_medico;
            this.tempo_atividade = tempo_atividade;
            this.especialidade = especialidade;
        }
        public void setnum_medico(string num_medico)
        {
            this.num_medico = num_medico;
        }
        public string getnum_medico()
        {
            return num_medico;
        }
        public void settempo_atividade(string tempo_atividade)
        {
            this.tempo_atividade = tempo_atividade;
        }
        public string gettempo_atividade()
        {
            return tempo_atividade;
        }
        public void setespecialidade(string especialidade)
        {
            this.especialidade = especialidade;
        }
        public string getespecialidade()
        {
            return especialidade;
        }


























    }
}
