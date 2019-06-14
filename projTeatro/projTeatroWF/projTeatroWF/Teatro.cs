using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace projTeatroWF
{
    //O programa ao iniciar esta lendo as entradas inteiras, como meia entrada.
    class Teatro
    {
        private Lugar[,] lugares;
        private double[] precos;
       
        public Lugar[,] Lugares //readonly
        {
            get { return this.lugares; }
        }

        public double[] Precos //readonly
        {
            get { return this.precos; }
        }

        public Teatro(double preco1, double preco2, double preco3)
        {
            this.lugares = new Lugar[15, 40];
            this.precos = new double[3];
            this.precos[0] = preco1;
            this.precos[1] = preco2;
            this.precos[2] = preco3;
            for (int f = 0; f < 15; ++f)
                for (int p = 0; p < 40; ++p)
                    this.lugares[f,p] = new Lugar();
        }

        public bool reservar(int fila, int poltrona, bool meiaEntrada)
        {
            bool podeReservar;
            podeReservar = !this.lugares[fila - 1, poltrona - 1].Ocupado;
            if (podeReservar)
            {
                lugares[fila - 1, poltrona - 1].Ocupado = true;
                lugares[fila - 1, poltrona - 1].MeiaEntrada = meiaEntrada;
            }
            return podeReservar;
        }
    
        public int qtdeOcupados()
        {
            int qtde;
            qtde = 0;
            foreach (Lugar lugar in this.lugares)
                if (lugar.Ocupado) 
                    qtde++;
            return qtde;
        }

        public double valorBilheteria()
        {
            double valor;
            valor = 0;
            for (int f = 0; f < 15; ++f)
                for (int p = 0; p < 40; ++p)
                    if (this.lugares[f, p].Ocupado)
                        valor += (this.lugares[f, p].MeiaEntrada) ? 
                            precos[f / 5] / 2 : 
                            precos[f / 5];
            return valor;
        }

        public void salvar()
        {
            Stream saida = File.Open("C:\\Users\\Public\\teste.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(saida);

            for(int x = 0; x < 15; x ++)
            {
                for(int y = 0; y < 40; y++)
                {
                    if (this.lugares[x, y].Ocupado)
                        escreve.Write("S");
                    else
                        escreve.Write("N");

                    if (this.lugares[x, y].MeiaEntrada)
                        escreve.WriteLine("S");
                    else
                        escreve.WriteLine("N");

                }
            }

            escreve.Close();
            saida.Close();
        }

        public void carregar()
        {
            Stream entrada = File.Open("C:\\Users\\Public\\teste.txt", FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
            string linha = leitor.ReadLine();
            
                for (int x = 0; x < 15; x++)
                {
                    for (int y = 0; y < 40; y++)
                    {
                        if (linha[0].ToString() == "S")
                            this.lugares[x, y].Ocupado = true;
                        else
                            this.lugares[x, y].Ocupado = false;

                        if (linha[0].ToString() == "S")
                            this.lugares[x, y].MeiaEntrada = true;
                        else
                            this.lugares[x, y].MeiaEntrada = false;

                    linha = leitor.ReadLine();
                    }
                }

            leitor.Close();
            entrada.Close();
        }

        public void apaga()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 40; y++)
                {
                        this.lugares[x, y].Ocupado = false;
                        this.lugares[x, y].MeiaEntrada = false;
                }
            }
        }

    }
}
