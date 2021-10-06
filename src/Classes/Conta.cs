using System;

namespace poo_concepts
{
    public abstract class Conta
    {
        private int agencia;
        public int Agencia
        {
            get { return agencia; }
            private set
            {
                if (value > 0)
                    agencia = value;
            }
        }
        private int numeroConta;
        public int NumeroConta
        {
            get { return numeroConta; }
            private set
            {
                if (value > 0)
                    numeroConta = value;
            }
        }
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        private decimal limite;
        public decimal Limite
        {
            get { return limite; }
            set { limite = value; }

        }

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }


        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public abstract void Depositar(decimal valor);
      

    }
}
