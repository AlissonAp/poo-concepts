using System;

namespace poo_concepts
{
    public class ContaPoupanca : Conta, ITributo
    {
        public ContaPoupanca(){

        }
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

        public decimal CalcularTributos(){
            return base.Saldo * 0.02m;
        }

    }
}
