using System;

namespace DIO.Sales
{
    public class Vendedor
    {
        private int Nivel { get; set; }
        private double TaxaGanho { get; set; }
        private string Nome { get; set; }
        private double TotalVendas { get; set; }
        private double TotalComissao { get; set; }

        public Vendedor(string nome, double totalVendas)
        {
            this.Nome = nome;
            this.TotalVendas = totalVendas;

            this.Nivel = CalculoNivel(totalVendas);
            this.TaxaGanho = CalculoTaxa(Nivel);
            this.TotalComissao = TotalVendas*TaxaGanho;
        }

        public int CalculoNivel(double valor)
        {

            int nivel = 0;

            if (valor > 0)
            {
                if (valor <= 1000)
                    nivel = 1;
                else if (valor <= 5000)
                    nivel = 2;
                else
                    nivel = 3;
               
                return nivel;
            } else
            {
                Console.WriteLine("Total de vendas R$ 0,00");
                return 0;
            }

        }

       

        public double CalculoTaxa(int nivel) 
        {
            double taxaganho;

            if (nivel == 1)
                taxaganho = 0.05;
            else if (nivel == 2)
                taxaganho = 0.07;
                else
                    taxaganho = 0.1;

            return taxaganho;
        }

        public override string ToString()
        {
            string retorno = "";
            
            retorno += "Nivel: " + this.Nivel + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Total de vendas: R$ " + this.TotalVendas + " | ";
            retorno += "Comissão: R$ " + this.TotalComissao + " | Taxa aplicada: "
                + this.TaxaGanho;

            return retorno;
            
        }



}
}