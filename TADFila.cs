using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    internal class TADFila
    {
        private class Nodulo
        {
            public int Codigo { get; set; }
            public string? Descricao { get; set; }
            public int Capacidade { get; set; }
            public Nodulo Next { get; set; }
            
            public Nodulo(int codigo, string descricao, int capacidade)
            {
                Codigo = codigo;
                Descricao = descricao;
                Capacidade = capacidade;
                Next = null;
            }
        }
        private Nodulo primeiro;
        private Nodulo ultimo;

        public TADFila(int codigo)
        {
            primeiro = null;
            ultimo = null;
            IncluirNaFila(codigo);
        }

        public int? RetirarDaFila()
        {
            if (primeiro == null)
            {
                Console.WriteLine("A fila está vazia.");
                return null;
            }
            int codigo = primeiro.Codigo;
            primeiro = primeiro.Next;
            if (primeiro == null)
            {
                ultimo = null;
            }
            return codigo;
        }

        public void IncluirNaFila(int k)
        {
            Console.WriteLine($"Digite a descrição do elemento de código {k}:");
            string descricao = Console.ReadLine();
            Console.WriteLine($"Digite a capacidade do elemento de código {k}");
            int capacidade = int.Parse(Console.ReadLine());
            Nodulo novoNodulo = new Nodulo(k, descricao, capacidade);
            if (ultimo == null)
            {
                primeiro = novoNodulo;
                ultimo = novoNodulo;
            } else {
                ultimo.Next = novoNodulo;
                ultimo = novoNodulo;
            }
        }

        public void ImprimirFila()
        {
            if (primeiro == null)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }
            Console.WriteLine("Conteúdo da fila:");
            Console.WriteLine($"Primeiro elemento: Código: {primeiro.Codigo}, Descrição: {primeiro.Descricao}, Capacidade: {primeiro.Capacidade}");
            Console.WriteLine($"Último elemento: Código: {ultimo.Codigo}, Descrição: {ultimo.Descricao}, Capacidade: {ultimo.Capacidade}");

            Nodulo atual = primeiro;
            while (atual != null)
            {
                Console.WriteLine($"Código: {atual.Codigo}, Descrição: {atual.Descricao}, Capacidade: {atual.Capacidade}");
                atual = atual.Next;
            }

        }
    }
}
