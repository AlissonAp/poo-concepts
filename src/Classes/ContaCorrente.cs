using System;

namespace poo_concepts
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        public decimal TaxaMovimento
        {
            get { return taxaMovimento; }
            set { taxaMovimento = value; }
        }

        public ContaCorrente() : base(999)
        {
            this.taxaMovimento = 0.1m;
        }

        public ContaCorrente(decimal limite) : base(limite)
        {
            this.taxaMovimento = 0.1m;
        }

        public override void Sacar(decimal valor){
            base.Sacar(valor + (taxaMovimento * valor));
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

    }
}
