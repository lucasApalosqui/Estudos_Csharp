using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleEstudos
{
    class ContaBancaria
    {
        /*Declaração das variáveis*/
        private int NumeroConta { get; }
        public string _titular;
        private double _saldo;
        private string _depositoInicial;


        /*Construtor que pede 2 parametros para funcionar*/
        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            _titular = titular;
            _depositoInicial = "n";
        }

        /*Construtor que pede 3 parametros para funcionar*/
        public ContaBancaria(int numeroConta, string titular, string depositoInicial)
        {
            NumeroConta = numeroConta;
            _titular = titular;
            _depositoInicial = depositoInicial;

            if(_depositoInicial == "s")
            {
                Console.WriteLine("Informe o valor que deseja depositar: ");
                DepositaValor(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
        }


        /*GET e SET do nome do titular, não deixando ser alterado para valor nulo ou com poucos caracteres*/
        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _titular = value;
                }
            }


        }

        private void MostraSaldo(double saldo)
        {
            Console.WriteLine("Olá " + _titular + " portador da conta de numero ( " + NumeroConta + " )\n" + " seu saldo atual é de: R$" + _saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void DepositaValor(double valor)
        {
           
            _saldo += valor;
            MostraSaldo(_saldo);
        }

        public void SacaValor(double valor)
        {
            _saldo = (_saldo - 5.0) - valor;
            MostraSaldo(_saldo);
        }



        

    }
}
