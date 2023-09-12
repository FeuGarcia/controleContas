using System;

namespace controleContasFer
{

    class Conta
    {
        public Cliente Titular { get; }
        public Agencia Agencia { get; }
        public Banco Banco { get; }
        public int Numero { get; }
        public double Saldo { get; private set; }
        // Caso o valor inicial for menor que 0,01 o sistem deveria retornar e pedir pro cliente inserir outro valor, mas não consegui fazer o programa voltar ao inicio, nem com return nem com while.

        public Conta(Cliente titular, Agencia agencia, Banco banco, int numero, double saldoInicial)
        {
            if (saldoInicial < 0.01)
            {
                throw new ArgumentException("Saldo inicial deve maior que R$0,01");
            }

            Titular = titular;
            Agencia = agencia;
            Banco = banco;
            Numero = numero;
            Saldo = saldoInicial;
        }
        // Se o valor do saque for maior que o saldo não da pra sacar, se for menor o saque é feito através do Saldo = Saldo - valor 
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        // Todo deposito é acrescentado sempre com Saldo = Saldo + valor
        public double Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Valor insuficiente pra sacar.");
                return Saldo;
            }
            else
            {
                Saldo -= valor;
                return Saldo;
            }
        }
    }
}