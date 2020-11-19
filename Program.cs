using System;

namespace contagem_regressiva200a100
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int conta = 200; conta >= 100; conta--){
                Console.WriteLine(conta);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
