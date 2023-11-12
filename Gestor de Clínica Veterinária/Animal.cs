using System.Collections.Generic;

namespace Gestor_de_Clínica_Veterinária
{
    public class Animal
    {
        private int id_animal;
        private string nome_animal;
        private string tipo_animal;
        private double peso_animal;
        private string dt_nasc;
        private char sexo;
        private string porte_animal;
        private string especie;
        private List<Intervencao> LI;

        public Animal(int id_animal, string nome_animal, string tipo_animal, double peso_animal, string dt_nasc, char sexo, string porte_animal, string especie)
        {
            this.id_animal = id_animal;
            this.nome_animal = nome_animal;
            this.tipo_animal = tipo_animal;
            this.peso_animal = peso_animal;
            this.dt_nasc = dt_nasc;
            this.sexo = sexo;
            this.porte_animal = porte_animal;
            this.especie = especie;
            LI = new List<Intervencao>();
        }
        public void setid_animal(int id_animal)
        {
            this.id_animal = id_animal;
        }
        public int getid_animal()
        {
            return id_animal;
        }
        public void setnome_animal(string nome_animal)
        {
            this.nome_animal = nome_animal;
        }
        public string getnome_animal()
        {
            return nome_animal;
        }
        public void settipo_animal(string tipo_animal)
        {
            this.tipo_animal = tipo_animal;
        }
        public string gettipo_animal()
        {
            return tipo_animal;
        }

        public void setpeso_animal(double peso_animal)
        {
            this.peso_animal = peso_animal;
        }
        public double getpeso_animal()
        {
            return peso_animal;
        }
        public void setdt_nasc(string dt_nasc)
        {
            this.dt_nasc = dt_nasc;
        }
        public string getdt_nasc()
        {
            return dt_nasc;
        }
        public void setsexo(char sexo)
        {
            this.sexo = sexo;
        }
        public char getsexo()
        {
            return sexo;
        }
        public void setporte_animal(string porte_animal)
        {
            this.porte_animal = porte_animal;
        }
        public string getporte_animal()
        {
            return porte_animal;
        }
        public void setespecie(string especie)
        {
            this.especie = especie;
        }
        public string getespecie()
        {
            return especie;
        }
        public void setLI(List<Intervencao> LI)
        {
            this.LI = LI;
        }
        public List<Intervencao> getLI()
        {
            return LI;
        }

        public void addListaInt(Intervencao inter)
        {
            LI.Add(inter);
        }
    }
}
