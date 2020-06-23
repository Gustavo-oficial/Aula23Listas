using System;

namespace Aula23Listas
{
    public class Cartão
    {
        public string Titular { get; set; }

        public int numero { get; set; }

        public string bandeira { get; set; }

        public string vencimento { get; set; }

        public int cvv { get; set; }

        public Cartão(){

        }

        public Cartão(string _titular, int _numero, string _bandeira,string _vencimento, int _cvv){
            this.Titular = _titular;
            this.numero = _numero; 
            this.bandeira = _bandeira;
            this.vencimento = _vencimento;
            this.cvv = _cvv;
        }
           
    }
}