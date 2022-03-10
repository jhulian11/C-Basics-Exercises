using System;

namespace Juros_Compostos
{
    class Program
    {

        static void Main()
        {

            Console.WriteLine("Com quanto de Capital iniciara o investimento ? ");
            int vf = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite o valor do seu Aporte Mensal: ");
            int V0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite quanto tempo deixara o seu dinheiro rendendo em meses: ");
            int TempM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros mensais: "); 
            double PercentJ = Convert.ToDouble(Console.ReadLine());


            Juros(V0,TempM, PercentJ, vf);
        }
        public static void Juros(float v0, float tempM, double percentJ,float vF)
        {
            float passiveRent;
            for (int i = 0; i < tempM; i++)
            {
                if (i == 0)
                {
                    vF += v0;
                    vF = (float)(vF * (1 + percentJ/100));
                }
                else 
                {
                    vF += v0;
                    vF = (float)(vF * (1 + percentJ / 100));
                }
            }
            passiveRent = (float)(vF * ( percentJ / 100));

            Console.WriteLine("No final do seu investimento você tera: "+vF+" Reais");
            Console.WriteLine("E tera uma renda passiva de : "+passiveRent+" Reais ao mês.");
        }
    }
}
