using System;

namespace poo_concepts
{
    class Program
    {
        static void Main(string[] args)
        {

            testarDeposito();
            testarException();

            Console.Read();
        }

        static void testarDeposito()
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(1000);
            cp.Depositar(1000);

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);

            Relatorio rel = new Relatorio();

            rel.SomarSaldos(cc);
            rel.SomarSaldos(cp);
            rel.SomarTributos(cp);

            Console.WriteLine(rel.SaldoGeral);
            Console.WriteLine(rel.TributoGeral);
        }

        static void testarException()
        {

            try
            {
                int a = 10;
                int b = 0;

                if (b == 0)
                {
                    throw new DivisaoZeroException();
                }


                int resultado = a / b;

                Console.WriteLine(resultado);

                int[] vetor = new int[] { 1, 2, 3 };

                Console.WriteLine(vetor[10]);

            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Erro: Divisão por zero");
                Console.WriteLine(ex.StackTrace);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro: índice fora do esperado");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Fim da execução");
            }

        }

    }
}
