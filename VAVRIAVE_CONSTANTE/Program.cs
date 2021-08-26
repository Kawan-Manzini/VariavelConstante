using System;

namespace VAVRIAVE_CONSTANTE
{
    class Program
    {

        //capslock atibado e _ para separar o nome de qualquer constante
        // não usar static pois toda constante ja é static

        public const int SAIDA_PROGRAMA = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
    }
}
