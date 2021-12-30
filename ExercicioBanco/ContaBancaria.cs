﻿using System.Globalization;

namespace ExercicioBanco
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) :this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", titular "
                + Titular
                + ", Saldo: R$:"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
