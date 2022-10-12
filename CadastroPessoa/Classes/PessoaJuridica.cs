using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {   

        public string? cnpj { get; set; }     

        public string? razaoSocial { get; set; }
        

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}