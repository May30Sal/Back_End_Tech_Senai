using System.Text.RegularExpressions;
using cadastroPessoaFS1.interfaces;

namespace cadastroPessoaFS1.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set;}

        public string ?razaosocial { get; set;}
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //método para ler os atributos da classe no console
        public override string ToString() {
            return this.nome + " " + this.cnpj + " " + this.razaosocial + " " + this.rendimento + " " + this.endereco;
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
    }
}