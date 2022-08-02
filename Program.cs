using System;

namespace Console_Entrada_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            String TextNome = Console.ReadLine();

            Console.WriteLine("Informe seu telefone:");
            String TextTelefone = Console.ReadLine();

            Console.WriteLine("Informe seu e-mail:");
            String TextEmail = Console.ReadLine();

            Rotulo_TextSexo:

            Console.WriteLine("Informe seu sexo:");
            String TextSexo = Console.ReadLine();

            if(TextSexo =="F" || TextSexo =="M" || TextSexo == "f" || TextSexo == "m")
            {
                Console.WriteLine("--> Sexo informado incorretamente");
            }

            else
            {
                Console.WriteLine("****Informe seu sexo corretamente ****");
                Console.WriteLine("  (M) para Masculino ");
                Console.WriteLine("  (F) para Feminino1 ");
                goto Rotulo_TextSexo;
            }

            Console.WriteLine("Dados informados");
            Console.WriteLine("Nome: " + TextNome);
            Console.WriteLine("Telefone: " + TextTelefone);
            Console.WriteLine("E-mail: " + TextEmail);
            Console.WriteLine("Sexo: " + TextSexo);
            Console.ReadLine();
        }
    }
}
