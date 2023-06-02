using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagamento Pgto;
        private short opcao;

        public ControlPagamento() 
        {
            Pgto =new Pagamento(); //criando uma conexão


        
        
        } //fim do construtor

        //get set

        public short ModificarOpcao
        {


            get { return opcao; }
            set { this.opcao = value; }
        }

        public void EscolherFormaDePagamento()
        {
            Console.WriteLine(Pgto.MenuFormaDePagamento());//Mostrando o menu na tela
            ModificarOpcao = Convert.ToInt16(Console.ReadLine()); //Coletando a resposta
        
        }// fim do registrar pagamento

        public void Operacao()
        {
            EscolherFormaDePagamento();
            
            switch (ModificarOpcao)
            {
                case 1:

                    Console.WriteLine("Pagamento com dinheiro: \n\n");
                    Console.WriteLine("Valor inserido na máquina: ");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nValor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    //utilizar o metodo  efetuar pagamento dinheiro
                    Pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(Pgto.imprimir());
                    break;
                 
                    case 2:

                    Console.WriteLine("Pagamento com dinheiro: \n\n");
                    Console.WriteLine("\n\nValor do Produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("\n\nCódigo do Cartão: ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nbandeiraCartao: \n1. Visa\n2. Mastercard/3.Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());
                    //utilizar o metodo efetuar pagamento dinheiro

                    Pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(Pgto.imprimir());
                    break;

                default:

                        Console.WriteLine("Impossivel realizar a operação, tente novamente!")
                    break;



            }

        }//fim da operacao

    } // fim da classe
} // fim do metodo
