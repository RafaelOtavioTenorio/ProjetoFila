namespace ProjetoFila
{
    internal class TestarFila
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInício main");
            TADFila fila = new TADFila(1);
            //fila.IncluirNaFila(5);
            //fila.IncluirNaFila(11);
            //fila.IncluirNaFila(3);
            //fila.ImprimirFila();
            //fila.IncluirNaFila(20);
            //fila.IncluirNaFila(5);
            //fila.ImprimirFila();
            //Console.WriteLine(fila.RetirarDaFila());
            //Console.WriteLine(fila.RetirarDaFila());
            //fila.ImprimirFila();

            do
            {
                try
                {
                    Console.WriteLine("O que deseja fazer? \n1- Adicionar elemento na fila. \n2- Remover elemento da fila. \n3- Imprimir fila.");
                    int selecao = int.Parse(Console.ReadLine());
                    switch (selecao)
                    {
                        case 1:
                            Console.WriteLine("\nDigite o código do elemento a ser adicionado na fila:");
                            fila.IncluirNaFila(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            fila.RetirarDaFila();
                            Console.WriteLine("\nElemento removido.");
                            break;
                        case 3:
                            fila.ImprimirFila();
                            break;
                    }
                    Console.WriteLine("\nDeseja realizar outra operação? \n1- Sim. \n2- Não.");
                    selecao = int.Parse(Console.ReadLine());
                    if (selecao == 2)
                    {
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nErro:");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\n");
                }
            } while (true);
            Console.WriteLine("\nFim main");
        }
    }
}