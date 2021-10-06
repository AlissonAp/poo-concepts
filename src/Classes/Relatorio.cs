using System;

namespace poo_concepts
{
    public class Relatorio
    {
        public decimal SaldoGeral { get; private set; }
        public decimal TributoGeral {get; private set;}

        public void SomarSaldos(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        public void SomarTributos(ITributo conta){
            this.TributoGeral += conta.CalcularTributos();
        }

        public void SomarValor(decimal valor1){
            this.SaldoGeral += valor1;
        }

        public void SomarValor(decimal valor1, decimal valor2){
            this.SaldoGeral += (valor1 + valor2);
        }

    }
}
