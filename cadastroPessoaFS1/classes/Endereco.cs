namespace cadastroPessoaFS1.classes
{
    public class Endereco
    {
        public string ?logradouro { get;set; }

        public int ?numero { get;set; }

        public string ?cidade { get;set; }

        public bool ?endComercial { get; set; }

        //método para ler o endereço completo no console
        public override string ToString() {
            return this.logradouro + " " + this.numero + " " + this.cidade + " " + this.endComercial;
        }
    }

}