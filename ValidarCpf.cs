using System;
namespace POO_Heranca
{
    public static class ValidarCpf
    {
       public static bool validCPF(string cpf){


        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		string auxCpf;
		string digito;
		int soma;
		int resto;

        cpf = cpf.Trim();
        cpf= cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        auxCpf = cpf.Substring(0, 9);
        soma=0;

        for(int i=0; i<9; i++)
		    soma += int.Parse(auxCpf[i].ToString()) * multiplicador1[i];

        resto = soma % 11;
		if ( resto < 2 )
		    resto = 0;
		else
		   resto = 11 - resto;
		digito = resto.ToString();
		auxCpf = auxCpf + digito;
		soma = 0;
		for(int i=0; i<10; i++)
		    soma += int.Parse(auxCpf[i].ToString()) * multiplicador2[i];
		resto = soma % 11;
		if (resto < 2)
		   resto = 0;
		else
		   resto = 11 - resto;
		digito = digito + resto.ToString();
		return cpf.EndsWith(digito);



       }

    }
}