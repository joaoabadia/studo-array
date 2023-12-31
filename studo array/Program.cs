class Lista
{
    int[] array;
    int n;
    public Lista() { 
        array = new int[6]; //numero de posições desejadas
        n = 0;
    }
    public Lista(int tamanho)
    {
        array = new int[tamanho];
        n = 0;
    }
    public void InserirInicio(int x)
    {
        Inserir(x, 0);
    }
    public void InserirFim(int x)
    {
        Inserir(x, n);
    }
    public void Inserir(int x, int pos)
    {
        if (n < array.Length && pos >=0 && pos <= n)
        {
            for (int i = n; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = x;
            n++;
        }
        else
        {
            Console.WriteLine("Posição Invalida ou array cheio.");
        }
    }
    public int RemoverInicio()
    {
        return Remover (0);
    }
    int RemoverFim()
    {
        return Remover(n - 1);
    }
    public int Remover(int pos)
    {
        if (n > 0 && pos >= 0 && pos < n)
        {
            int removido = array[pos];
            for (int i = pos; i < n - 1 ; i++)
            {
                array[i] = array[i + 1];
            }

            n--;
            return removido;
        }
        else
        {
            Console.WriteLine("Posição Invalida ou array vazio. ");
            return -1;
        }
    }
    public void Mostrar()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==== LISTA LINEAR ====");
            Lista lista = new Lista(6);

            lista.InserirInicio(1);
            lista.InserirFim(7);
            lista.InserirFim(9);
            lista.InserirInicio(3);
            lista.Inserir(8, 3);
            lista.Inserir(4, 2);

            Console.Write("Lista inicial: ");
            lista.Mostrar();

            int x1 = lista.RemoverInicio();
            int x2 = lista.RemoverFim();
            int x3 = lista.Remover(2);

            Console.WriteLine($"Elementos removidos: {x1}, {x2}, {x3}");

            Console.Write("Lista após remoções: ");
            lista.Mostrar();
        }
    }
}