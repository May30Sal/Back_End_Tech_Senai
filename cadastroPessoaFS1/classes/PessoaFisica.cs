using cadastroPessoaFS1.interfaces;

namespace cadastroPessoaFS1.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }

        public DateTime ?dataNascimento { get; set; }
        
        
        public bool ValidarDataNascimento(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}