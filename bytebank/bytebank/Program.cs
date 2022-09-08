﻿using bytebank;
using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
{
    try
    {
        ContaCorrente contaCorrente = new ContaCorrente(0, 52665);
        contaCorrente.Depositar(50);
        Console.WriteLine(contaCorrente.Saldo);
        contaCorrente.Sacar(200);
        Console.WriteLine(contaCorrente.Saldo);


    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro no parâmetro " + ex.ParamName);
        Console.WriteLine("Ocorreu um erro do tipo Argument Exception");
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine(ex.Message);

    }
    catch (SaldoInsuficienteException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Exceção do tipo SaldoInsuficenteException");
    }
}
