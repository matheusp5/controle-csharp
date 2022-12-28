using System;
using System.Net.Mail;

namespace LojaVirtualHx.Entities
{
    class Bebida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }
    }
}
