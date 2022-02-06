using cadastroPessoaFS1.interfaces;

namespace cadastroPessoaFS1.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }

        public string ?dataNascimento { get; set; }
        
        

          public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                 DateTime dataAtual = DateTime.Today;

                  double anos = (dataAtual - dataConvertida).TotalDays / 365;

                 if (anos >= 18)
                 {
                    return true;
                 }
            }
            return false;
            
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}