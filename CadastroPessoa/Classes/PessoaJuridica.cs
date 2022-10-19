using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {   

        public string? cnpj { get; set; }     

        public string? razaoSocial { get; set; }

        // Para rendimentos ate 3000, 3%
        // Para rendimentos entre 3000 e 6000, 5%
        // Para rendimentos entre 6000 e 10000, 7%
        // Para rendimentos acima de 10000, 9%

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }else 
            {
                return rendimento * .09f;
            }
        }

        // xx.xxx.xxx/xxx1-xx
        // xxxxxxxxxxx1xx

        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})$");

            if (retornoCnpjValido)
            {
                string subStringCnpj = cnpj.Substring(8, 4);

                if (subStringCnpj == "0001")
                {
                    return true;
                }
            }

            return false;
        }
    }
}