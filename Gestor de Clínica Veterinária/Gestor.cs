using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gestor_de_Clínica_Veterinária
{
    public class Gestor
    {

        private List<Veterinario> LV;
        private List<Dono> LD;

        public Gestor()
        {
            LV = new List<Veterinario>();
            LD = new List<Dono>();
        }
        public List<Dono> getListaDono()
        {
            return LD;
        }

        public List<Veterinario> getListaVet()
        {
            return LV;
        }

        //Alínea a)
        public string InserirDono(string nome, string telefone)
        {
            string s;
            int maior = 0;
            int id = 1;
            foreach (Dono don in LD)
            {
                if (don.getid_dono() > maior)
                {
                    maior = don.getid_dono();
                }
                id = maior + 1;
            }
            Dono dono = new Dono(id, nome, telefone);
            LD.Add(dono);
            s = "O seu número de ID é: " + id + ".";
            return s;
        }

        //Alínea a)
        public string InserirAnimal(string id_dono, string nome_animal, string tipo_animal, double peso_animal, string dt_nasc, char sexo, string porte_animal, string especie)
        {
            string s;
            int maior = 0;
            int id = 1;
            Dono X = Pesquisar_Dono(id_dono);
            foreach (Dono don in LD)
            {
                foreach (Animal an in don.getLA())
                {
                    if (an.getid_animal() > maior)
                    {
                        maior = an.getid_animal();
                    }
                    id = maior + 1;
                }
            }
            Animal animal = new Animal(id, nome_animal, tipo_animal, peso_animal, dt_nasc, sexo, porte_animal, especie);
            if (X != null)
                X.AddAnimal(animal);
            s = "Animal inserido com sucesso!";
            return s;
        }

        //Alínea b)
        public string InserirVet(string num_medico, string tempo_atividade, string especialidade, string nome, string telefone)
        {
            string s;
            Veterinario vet = new Veterinario(num_medico, tempo_atividade, especialidade, nome, telefone);
            if (nome != "" && num_medico != "" && tempo_atividade != "" && especialidade != "" && telefone != "")
            {
                s = "Veterinário inserido com sucesso!";
                LV.Add(vet);
            }
            else
            {
                s = "Preencha todos os espaços em branco!";
            }
            return s;
        }

        //Alínea c)
        public string InserirConsulta(string tipo_consulta, string veterinario, DateTime data, double custo, string id_animal)
        {
            string s;
            Animal X = Pesquisar_Animal(id_animal);
            if (X != null)
            {
                Consulta inter = new Consulta(tipo_consulta, veterinario, data, custo);
                X.addListaInt(inter);
                s = "Intervenção inserida com sucesso!";
                return s;
            }

            return null;
        }

        //Alínea c)
        public string InserirCirurgia(string tipo_cirurgia, string veterinario, DateTime data, double custo, string id_animal)
        {
            string s;
            Animal X = Pesquisar_Animal(id_animal);
            if (X != null)
            {
                Cirurgia inter = new Cirurgia(tipo_cirurgia, veterinario, data, custo);
                X.addListaInt(inter);
                s = "Intervenção inserida com sucesso!";
                return s;
            }
            else
            {
                MessageBox.Show("Animal não existe!");
            }
            return null;
        }

        //Alínea c)
        public string InserirVacinacao(string tipo_consulta, DateTime validade, string veterinario, DateTime data, double custo, string id_animal)
        {
            string s;
            Animal X = Pesquisar_Animal(id_animal);
            if (X != null)
            {
                Vacinacao inter = new Vacinacao(tipo_consulta, validade, veterinario, data, custo);
                X.addListaInt(inter);
                s = "Intervenção inserida com sucesso!";
                return s;
            }
            else
            {
                MessageBox.Show("Animal não existe!");
            }
            return null;
        }

        //Método que dá return do custo de uma intervenção segundo o tipo do animal, o seu peso e o preço de cada intervenção
        public double AddCustoInt(string tipo_escolhido, char tipo, string tipo_intervencao, string veterinario, DateTime data, double custo, DateTime validade, string id_animal)
        {
            Animal X = Pesquisar_Animal(id_animal);
            if (tipo == 'c')
            {
                Cirurgia cir = new Cirurgia(tipo_intervencao, veterinario, data, custo);
                return cir.CustoIntervencao(tipo_escolhido, X.gettipo_animal(), X.getpeso_animal());
            }
            else if (tipo == 'g')
            {
                Consulta con = new Consulta(tipo_intervencao, veterinario, data, custo);
                return con.CustoIntervencao(tipo_escolhido, X.gettipo_animal(), X.getpeso_animal());
            }
            else if (tipo == 'v')
            {
                Vacinacao vac = new Vacinacao(tipo_intervencao, validade, veterinario, data, custo);
                return vac.CustoIntervencao(tipo_escolhido, X.gettipo_animal(), X.getpeso_animal());
            }
            else
            {
                return 0;
            }
        }

        //Método que dá return de um Dono se este for encontrado a partir do id
        public Dono Pesquisar_Dono(string id)
        {
            foreach (Dono X in LD)
                if (X.getid_dono().ToString().CompareTo(id) == 0)
                    return X;
            return null;
        }

        //Método que dá return de um Animal se este for encontrado a partir do id
        public Animal Pesquisar_Animal(string id)
        {
            foreach (Dono don in LD)
            {
                foreach (Animal X in don.getLA())
                    if (X.getid_animal().ToString().CompareTo(id) == 0)
                        return X;
            }
            return null;
        }

        //Méotodo que server para repartir um id e nome de um Animal quando estes estão juntos mas só queremos usar o id
        public string splitidanimal(string id_animal)
        {
            string[] partes;
            partes = id_animal.Split(' ');
            string id_an = partes[0];
            return id_an;
        }

        //Alínea i)
        public string CustoInt_Animal(string id_animal)
        {
            double custo = 0;
            string s = "";
            Animal X = Pesquisar_Animal(id_animal);
            foreach (Intervencao Y in X.getLI())
            {
                custo = custo + Y.getcusto();
            }
            return s = "Total gasto do animal: " + custo + "€";
        }

        //Alínea j)
        public string CustoInt_Dono(string id_dono)
        {
            double custo = 0;
            string s = "";
            Dono X = Pesquisar_Dono(id_dono);
            foreach (Animal Y in X.getLA())
            {
                foreach (Intervencao inter in Y.getLI())
                {
                    custo = custo + inter.getcusto();
                }
            }
            return s = "Total gasto no veterinário: " + custo + "€";
        }

        //Alínea k)
        public string Tipo_maisInt()
        {
            Dictionary<string, int> tipomaisint = new Dictionary<string, int>();
            string tipo_animal;
            int cont = 0;
            string s = "";
            int maior = -100;
            foreach (Dono don in LD)
            {
                foreach (Animal X in don.getLA())
                {
                    tipo_animal = X.gettipo_animal();
                    if (tipomaisint.ContainsKey(tipo_animal))
                    {
                        cont = X.getLI().Count;
                        tipomaisint[tipo_animal] = tipomaisint[tipo_animal] + cont;
                    }
                    else
                    {
                        cont = X.getLI().Count;
                        tipomaisint.Add(tipo_animal, cont);
                    }
                    foreach (KeyValuePair<string, int> Y in tipomaisint)
                    {
                        if (Y.Value > maior)
                        {
                            maior = Y.Value;
                            s = "O tipo de animal com mais intervenções é " + Y.Key + " com " + maior + " de intervenções.";
                        }
                        if (maior == 0)
                        {
                            s = "";
                        }
                    }
                }

            }
            return s;
        }

        //Alínea l)
        public void Lerficheiro_Vet(string fich)
        {
            StreamReader sr = new StreamReader(fich);
            try
            {
                string linha;
                string[] partes;
                List<Veterinario> LV = getListaVet();
                while ((linha = sr.ReadLine()) != null)
                {
                    partes = linha.Split('-');
                    string num_medico = partes[0];
                    string nome = partes[1];
                    string telefone = partes[2];
                    string especialidade = partes[3];
                    string tempo_atividade = partes[4];
                    Veterinario vet = new Veterinario(num_medico, tempo_atividade, especialidade, nome, telefone);
                    LV.Add(vet);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message, "Erro!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

        //Alínea l)
        public void Lerficheiro_Animal_Dono_Int(string fich)
        {
            StreamReader F = new StreamReader(fich);
            try
            {
                string[] partsdono;
                string[] partsanimal;
                string[] partsint;
                string[] divisao;
                string linha;
                List<Dono> LD = getListaDono();
                List<Animal> LA;
                List<Intervencao> LI;
                linha = F.ReadLine();
                while (linha != null)
                {
                    partsdono = linha.Split('-');
                    Dono X;
                    int id_dono = Convert.ToInt32(partsdono[0]);
                    string nome_dono = partsdono[1];
                    string telefone = partsdono[2];
                    X = new Dono(id_dono, nome_dono, telefone);
                    LD.Add(X); 
                    linha = F.ReadLine(); //até aqui lê as informações do Dono que estão na primeira linha, adiciona o Dono e vai para a linha seguinte
                    while (linha.Equals("----------------------------------------------") == false)
                    {
                        LA = X.getLA();
                        Animal Y;
                        partsanimal = linha.Split('-');
                        int id_animal = Convert.ToInt32(partsanimal[0]);
                        string nome_animal = partsanimal[1];
                        string tipo_animal = partsanimal[2];
                        double peso_animal = Convert.ToDouble(partsanimal[3]);
                        string dt_nasc = partsanimal[4];
                        char sexo = Convert.ToChar(partsanimal[5]);
                        string porte_animal = partsanimal[6];
                        string especie = partsanimal[7];
                        Y = new Animal(id_animal, nome_animal, tipo_animal, peso_animal, dt_nasc, sexo, porte_animal, especie);
                        X.AddAnimal(Y); 

                        divisao = linha.Split(';');  //na linha seguinte lê as informações do Animal e adiciona o mesmo até ao primeiro ;(ponto e vírgula)
                        for (int i = 1; i < divisao.Length; i++) //fazemos a divisão da linha (do Animal e das suas Intervenções) por pontos e vírgulas e adicionamos tudo num array pois a informação até ao primeiro ponto e vírgula é informações do animal e depois do primeiro ; é tudo intervenções desse mesmo animal
                        {                                        //com o array divisao fazemos um ciclo for em que dizemos que do 2º elemento (1 no array) para a frente é tudo intervenções e adicionamos-as à lista de Intervenções
                            LI = Y.getLI();
                            Intervencao W;
                            partsint = divisao[i].Split('-');
                            string inter = partsint[3];
                            if (inter == "Cirurgia")
                            {
                                string tipo_cirurgia = partsint[4];
                                string veterinario = partsint[0];
                                DateTime data = Convert.ToDateTime(partsint[1]);
                                double custo = Convert.ToDouble(partsint[2]);
                                W = new Cirurgia(tipo_cirurgia, veterinario, data, custo);
                                LI.Add(W);
                            }
                            else if (inter == "Consulta")
                            {
                                string tipo_consulta = partsint[4];
                                string veterinario = partsint[0];
                                DateTime data = Convert.ToDateTime(partsint[1]);
                                double custo = Convert.ToDouble(partsint[2]);
                                W = new Consulta(tipo_consulta, veterinario, data, custo);
                                LI.Add(W);
                            }
                            else
                            {
                                string tipo_consulta = partsint[4];
                                string veterinario = partsint[0];
                                DateTime data = Convert.ToDateTime(partsint[1]);
                                double custo = Convert.ToDouble(partsint[2]);
                                DateTime validade = Convert.ToDateTime(partsint[5]);
                                W = new Vacinacao(tipo_consulta, validade, veterinario, data, custo);
                                LI.Add(W);
                            }
                        }
                        linha = F.ReadLine();  //lê a linha seguinte, se for mais um animal e as suas intervenções adiciona se for ----------------- é porque acabou os Animais do Dono adicionado anteriormente e então irá adicionar um novo Dono e outros animais desse mesmo
                    }
                    linha = F.ReadLine();
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "Erro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                if (F != null)
                    F.Close();
            }
        }

        //Alínea l)
        public void GravarFicheiroVet(string caminho)
        {
            StreamWriter writer = new StreamWriter(caminho);

            try
            {
                foreach (Veterinario v in LV)
                {
                    writer.WriteLine(v.getnum_medico() + "-" + v.getnome() + "-" + v.gettelefone() + "-" + v.getespecialidade() + "-" + v.gettempo_atividade());
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "Erro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        //Alínea l)
        public void GravarFichDono_Animais_Int(string fich)
        {
            StreamWriter sw = new StreamWriter(fich);
            try
            {
                foreach (Dono W in LD)
                {
                    sw.WriteLine(W.getid_dono()  + "-" + W.getnome() + "-" + W.gettelefone());
                    foreach (Animal X in W.getLA())
                    {
                        sw.Write(X.getid_animal() + "-" + X.getnome_animal() + "-" + X.gettipo_animal() + "-" + X.getpeso_animal() + "-" + X.getdt_nasc() + "-" + X.getsexo() + "-" + X.getporte_animal() + "-" + X.getespecie() + "-");
                        foreach (Intervencao Y in X.getLI())
                        {
                            Y.Gravar(sw);
                        }
                        sw.WriteLine();
                    }
                    sw.WriteLine("----------------------------------------------");
                }
                MessageBox.Show("Dados guardados com sucesso!");
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "Erro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }






    }
}
