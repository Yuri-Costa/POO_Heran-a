using System;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
           PessoaFisica pf = new PessoaFisica();
            pf.cPF = "000.000.000-00";
            pf.rG= "111.111.111-1";
            pf.nome= "Yuri";

            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            Console.WriteLine(pf.ValidarCpf(pf.cPF));


             PessoaJuridica pj = new PessoaJuridica();
              pj.cNPJ = "222.222.222-22";
              pj.rG= "111.111.111-1";
              pj.nome= "Yuri";

            Console.WriteLine(pj.DarBoasVindas(pj.nome));
            Console.WriteLine(pj.ValidarCnpj(pj.cNPJ));




        }
    }
}
