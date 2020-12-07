namespace POO_Heranca
{
    public class PessoaFisica : Pessoa
    {
        public string cPF;
        public string rG;

        public bool ValidarCpf (string documento){
            if (documento.Length > 10)
            {return true;

            }return false;
        }






        
    }
}