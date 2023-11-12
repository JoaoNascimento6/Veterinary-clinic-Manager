using System.Collections.Generic;

namespace Gestor_de_Clínica_Veterinária
{
    public class Dono : Pessoa
    {
        private int id_dono;
        private List<Animal> LA;

        public Dono(int id_dono, string nome, string telefone) : base(nome, telefone)
        {
            this.id_dono = id_dono;
            LA = new List<Animal>();
        }
        public void setid_dono(int id_dono)
        {
            this.id_dono = id_dono;
        }
        public int getid_dono()
        {
            return id_dono;
        }
        public void setLA(List<Animal> LA)
        {
            this.LA = LA;
        }
        public List<Animal> getLA()
        {
            return LA;
        }

        public void AddAnimal(Animal y)
        {
            LA.Add(y);
        }

    }
}

