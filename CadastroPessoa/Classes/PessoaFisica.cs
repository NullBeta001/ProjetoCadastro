using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }


        // Para rendimentos ate 1500, isento
        // Para rendimentos entre 1501 e 3500 2%
        // Para rendimentos entre 3501 e 6000, 3,5%
        // Para rendimentos acima de 6001, 5%

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;

                return resultado;

            }else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;

                return resultado;

            }else
            {
                float resultado = (rendimento / 100) * 5;

                return resultado;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}