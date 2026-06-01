using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // Variavel em C# , exige falar o tipo e o nome...
            double raio = 4.5;

            // Constante , a diferenca entre o double é que a constante altera.
            const double pi = 3.14;
            double area = pi * raio * raio;
            int idade = 30;
            bool temGato = false;
            var nome = "Neymar";

            byte idadeNeymar = 34; //0 a 255
            sbyte saldo = -10; //-128 a 127
            uint salarioNeymar = 999999999; // 9 casas decimais
            long salarioRealNey = 9999999999; // 10 casas decimais
            ulong salarioRealVerdadeiroNey = 999999999999; // 12 casas decimais
            DateTime dataNascimento = new DateTime(1992, 02, 05);


            Console.WriteLine("A area total é " + area);
            Console.WriteLine($"Neymar ganha {salarioRealVerdadeiroNey}");
        }
    }
}
