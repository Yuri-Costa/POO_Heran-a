namespace POO_Heranca
{
    public class PessoaJuridica : Pessoa
    {
         public string cNPJ;
        public string rG;

        public bool ValidarCnpj (string documento){
            if (documento.Length > 10)
            {return true;

            }return false;
        }
    }
}