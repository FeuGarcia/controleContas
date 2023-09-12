using System;
using controleContasFer;

//Classe para pegar os dados do cliente, se o cpf tiver menos que 11 números ou a idade for menor que 18 será dado como invalido. Não conseguir colocar o código pra parar quando isso acontecesse. Break não funcionou.
class Cliente
{
    public string Nome { get; }
    public string CPF { get; }
    public int Idade { get; }

    public Cliente(string nome, string cpf, int idade)
    {
        if (cpf.Length != 11 || idade <= 18)
        {
            Console.WriteLine("CPF deve ter 11 dígitos e sem pontos, idade deve ser igual ou maior que 18.");
        }

        Nome = nome;
        CPF = cpf;
        Idade = idade;
    }
}

//Classe do Banco, com número e número
class Banco
{
    public string Nome { get; }
    public int Numero { get; }

    public Banco(string nome, int numero)
    {
        Nome = nome;
        Numero = numero;
    }
}

// Classe da agencia com os dados da agencia
class Agencia
{
    public string Nome { get; }
    public string Numero { get; }
    public string CEP { get; }
    public string Telefone { get; }

    public Agencia(string nome, string numero, string cep, string telefone = "")
    {
        Nome = nome;
        Numero = numero;
        CEP = cep;
        Telefone = telefone;
    }
}