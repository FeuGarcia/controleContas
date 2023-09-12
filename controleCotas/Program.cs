// See https://aka.ms/new-console-template for more information
using controleContasFer;

class Program
{
    static void Main(string[] args)
    {
        // Cliente1
        Cliente cliente1 = new Cliente("João", "12345678911", 25);

        // Banco1
        Banco banco1 = new Banco("Banco Santander", 123);

        // Agência1
        Agencia agencia1 = new Agencia("001", "12345", "12345678");

        // Conta1
        Conta conta1 = new Conta(cliente1, agencia1, banco1, 123456, 857.97);

        // Conta2
        Conta conta2 = new Conta(cliente1, agencia1, banco1, 654321, 2341.42);

        // Saque e Depósito
        // conta1.Depositar(double.Parse(Console.ReadLine())); também poderia  ser feito dessa forma
        // conta1.Sacar(double.Parse(Console.ReadLine())); 
        conta1.Depositar(350.0);
        conta1.Sacar(150.0);

        conta2.Depositar(1500.0);
        conta2.Sacar(1000.0);

        // Soma do saldo das contas, número da conta, banco, agencia e saldo dos dados das contas.
        double somaDosSaldos = conta1.Saldo + conta2.Saldo;
        Console.WriteLine($"Soma dos saldos das contas: R$ {somaDosSaldos.ToString("C2")}");
        Console.WriteLine($"Conta 1: Número: {conta1.Numero}, Banco: {banco1.Nome}, Agencia: {agencia1.Nome}, Saldo: {conta1.Saldo.ToString("C2")}");
        Console.WriteLine($"Conta 2: Número: {conta2.Numero}, Banco: {banco1.Nome}, Agencia: {agencia1.Nome}, Saldo: {conta2.Saldo.ToString("C2")}");
    }
}