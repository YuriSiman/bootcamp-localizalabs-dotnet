namespace Xenlonguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                int resultadoFinal = 0, count = 0;
                int esferas = int.Parse(Console.ReadLine());

                if (esferas >= 2 && esferas <= 1000)
                {
                    for (int j = 1; j <= esferas; j++)
                    {
                        bool repete = true;
                        int valorAux = 0;

                        while (repete)
                        {
                            if (valorAux < j)
                            {
                                var resultado = (double)j / (valorAux + 1);

                                if (resultado % 1 == 0) count++;
                                valorAux++;
                            }
                            else
                            {
                                repete = false;
                            }
                        }

                        if (count % 2 == 0) resultadoFinal++;
                        count = 0;
                    }
                }
                Console.WriteLine(resultadoFinal);
            }
        }
    }
}