using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }else
            {
                return 1;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}