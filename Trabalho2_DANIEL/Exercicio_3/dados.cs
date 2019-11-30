using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
    public class dados : IComparable<dados>
    {
        public int codigo { get; set; }
        public int cpfcnpj { get; set; }
        public string nomerazao { get; set; }
        public string nomefantansia { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public int telefone { get; set; }
        public int cep { get; set; }
        public string email { get; set; }
        public int CompareTo(dados dado)
        {
            return this.nomerazao.CompareTo(dado.nomerazao);
        }
    }
}
