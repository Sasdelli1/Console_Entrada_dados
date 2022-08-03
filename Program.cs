using System;

namespace Console_Entrada_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            String TextNome = Console.ReadLine();

            Console.WriteLine("Informe seu sobrenome:");
            String TextSobrenome = Console.ReadLine();

            Console.WriteLine("Informe sua data de nascimento:");
            String TextNascimento = Console.ReadLine();

            Rotulo_ufNascimento:

            Console.WriteLine("Informe seu local:");
            String TextufNascimento = Console.ReadLine();

            if(TextufNascimento.ToUpper() == "SP" || TextufNascimento.ToUpper() == "RJ" || TextufNascimento.ToUpper() == "PR" || TextufNascimento.ToUpper() == "SC" || TextufNascimento.ToUpper() == "RS" || TextufNascimento.ToUpper() == "AC" ||
                TextufNascimento.ToUpper() == "AL" || TextufNascimento.ToUpper() == "AP" || TextufNascimento.ToUpper() == "AM" || TextufNascimento.ToUpper() == "BA" || TextufNascimento.ToUpper() == "CE" || TextufNascimento.ToUpper() == "DF" ||
                TextufNascimento.ToUpper() == "ES" || TextufNascimento.ToUpper() == "GO" || TextufNascimento.ToUpper() == "MA" || TextufNascimento.ToUpper() == "MT" || TextufNascimento.ToUpper() == "MS" || TextufNascimento.ToUpper() == "MG" ||
                TextufNascimento.ToUpper() == "PA" || TextufNascimento.ToUpper() == "PB" || TextufNascimento.ToUpper() == "PE" || TextufNascimento.ToUpper() == "PI" || TextufNascimento.ToUpper() == "RN" || TextufNascimento.ToUpper() == "RO" ||
                TextufNascimento.ToUpper() == "RR" || TextufNascimento.ToUpper() == "SE" || TextufNascimento.ToUpper() == "TO")
            {
                Console.WriteLine("--> UF informado corretamente");
            }

            else
            {
                Console.WriteLine("Escreva novamente, sigla invalida");
                goto Rotulo_ufNascimento;
            }

            Rotulo_TextSexo:

            Console.WriteLine("Informe seu sexo:");
            String TextSexo = Console.ReadLine();

            if(TextSexo =="F" || TextSexo =="M" || TextSexo == "f" || TextSexo == "m")
            {
                Console.WriteLine("--> Sexo informado corretamente");
            }

            else
            {
                Console.WriteLine("****Informe seu sexo corretamente ****");
                Console.WriteLine("  (M) para Masculino ");
                Console.WriteLine("  (F) para Feminino1 ");
                goto Rotulo_TextSexo;
            }

            Console.WriteLine("Informe seu endereço:");
            String TextEndereço = Console.ReadLine();

            Console.WriteLine("Informe seu bairro :");
            String TextBairro = Console.ReadLine();

            Console.WriteLine("Informe seu cidade :");
            String TextCidade = Console.ReadLine();

            Console.WriteLine("Informe seu CEP :");
            String TextCEP = Console.ReadLine();

            Rotulo_UnidadeEndereço:

            Console.WriteLine("Informe seu UF :");
            String TextUnidadeEndereço = Console.ReadLine();

            if (TextUnidadeEndereço.ToUpper() == "SP" || TextUnidadeEndereço.ToUpper() == "RJ" || TextUnidadeEndereço.ToUpper() == "PR" || TextUnidadeEndereço.ToUpper() == "SC" || TextUnidadeEndereço.ToUpper() == "RS" || TextUnidadeEndereço.ToUpper() == "AC" ||
                TextUnidadeEndereço.ToUpper() == "AL" || TextUnidadeEndereço.ToUpper() == "AP" || TextUnidadeEndereço.ToUpper() == "AM" || TextUnidadeEndereço.ToUpper() == "BA" || TextUnidadeEndereço.ToUpper() == "CE" || TextUnidadeEndereço.ToUpper() == "DF" ||
                TextUnidadeEndereço.ToUpper() == "ES" || TextUnidadeEndereço.ToUpper() == "GO" || TextUnidadeEndereço.ToUpper() == "MA" || TextUnidadeEndereço.ToUpper() == "MT" || TextUnidadeEndereço.ToUpper() == "MS" || TextUnidadeEndereço.ToUpper() == "MG" ||
                TextUnidadeEndereço.ToUpper() == "PA" || TextUnidadeEndereço.ToUpper() == "PB" || TextUnidadeEndereço.ToUpper() == "PE" || TextUnidadeEndereço.ToUpper() == "PI" || TextUnidadeEndereço.ToUpper() == "RN" || TextUnidadeEndereço.ToUpper() == "RO" ||
                TextUnidadeEndereço.ToUpper() == "RR" || TextUnidadeEndereço.ToUpper() == "SE" || TextUnidadeEndereço.ToUpper() == "TO")
            {
                Console.WriteLine("--> UF informado corretamente");
            }

            else
            {
                Console.WriteLine("Escreva novamente, sigla invalida");
                goto Rotulo_UnidadeEndereço;
            }

            Console.WriteLine("Dados informados");
            Console.WriteLine("Nome: " + TextNome);
            Console.WriteLine("Sobrenome: " + TextSobrenome);
            Console.WriteLine("Data de Nascimento: " + TextNascimento);
            Console.WriteLine("Sexo: " + TextSexo);
            Console.WriteLine("UF Nascimento: " + TextufNascimento);
            Console.WriteLine("Endereço: " + TextEndereço);
            Console.WriteLine("Bairro: " + TextBairro);
            Console.WriteLine("Cidade: " + TextCidade);
            Console.WriteLine("CEP: " + TextCEP);
            Console.WriteLine("UF: " + TextUnidadeEndereço);
            Console.ReadLine();
        }
    }
}
