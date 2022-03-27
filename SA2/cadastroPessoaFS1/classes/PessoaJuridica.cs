using System.Text.RegularExpressions;
using cadastroPessoaFS1.interfaces;

namespace cadastroPessoaFS1.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set;}

        public string ?razaosocial { get; set;}

        public string caminho { get; private set;} = "Database/PessoaJuridica.csv";
        
        public override float PagarImposto(float rendimento)
        {
            
            if(rendimento <= 3000)
            {
                return rendimento * 0.03f;
            } 
            else if(rendimento <= 6000)
            {
                return rendimento * 0.05f;
            }
            else if(rendimento <= 10000)
            {
                return (rendimento / 100) * 0.07f;
            }
            else
            {
                 return rendimento * 0.09f;
            }
        }

        //método para ler os atributos da classe no console
        public override string ToString() {
            return "Razão Social: " + this.razaosocial + ". CNPJ: " + this.cnpj + ". Rendimento: " + this.rendimento.ToString("C");
        }

        //xx.xxx.xxx/0001-xx ou xxxxxxxx0001xx
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11,4) == "0001")
                    return true; 
                } 
                else {
                    if (cnpj.Substring(8,4) == "0001")
                    return true;
                }
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj){
            string[] pjString = {$"{pj.ToString()}"};

            VerificarPastaArquivo(caminho);

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> Ler(){

            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

            string[] linhas  = File.ReadAllLines(caminho);

            // listaPJ;

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");
                PessoaJuridica cadaPj = new PessoaJuridica();
                cadaPj.razaosocial = atributos[0];
                cadaPj.cnpj = atributos[1];

                listaPJ.Add(cadaPj);
            }

            return listaPJ;
        }
    }
}