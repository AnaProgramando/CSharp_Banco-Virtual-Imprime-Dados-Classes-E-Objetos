using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ImprimeDadosClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaAna;
            contaAna = new ContaCorrente();
            
            contaAna.titular = "Ana";
            contaAna.agencia = 123;
            contaAna.numConta = 123456;
            contaAna.saldo = 100;

            Console.WriteLine("Imprimindo dados utilizando classe e objetos: \r\n");

            Console.WriteLine("Titular: " + contaAna.titular + ".");
            Console.WriteLine("Agência: " + contaAna.agencia + ".");
            Console.WriteLine("Conta: " + contaAna.numConta + ".");
            Console.WriteLine("Saldo: R$ " + contaAna.saldo + ".");

            contaAna.saldo += 200;
            Console.WriteLine("O saldo atualizado é: R$ " + contaAna.saldo + ".");

            Console.ReadLine();
        }
    }
}
