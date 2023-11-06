using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable hash = new Hashtable();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            hash.Add(cpf, telefone);
        }

        Console.WriteLine("\nDados inseridos:");

        foreach (DictionaryEntry entry in hash)
        {
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        }

        Console.WriteLine("\nPesquisar por CPF:");

        while (true)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (hash.ContainsKey(cpf))
            {
                Console.WriteLine("Telefone: {0}", hash[cpf]);
            }
            else
            {
                Console.WriteLine("CPF não encontrado.");
            }
        }
    }
}

