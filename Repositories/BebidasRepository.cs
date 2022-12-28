using LojaVirtualHx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualHx.Repositories
{
    internal class BebidasRepository
    {
        static List<Bebida> bebidas = new List<Bebida>()
        {
            new Bebida() { Id = 1, Nome = "Agua sem gas", Valor = 3, Estoque = 3 },
            new Bebida() { Id = 2, Nome = "Fanta uva", Valor = 5, Estoque = 3 },
            new Bebida() { Id = 3, Nome = "Coca-cola", Valor = 5, Estoque = 3 },
        };

        public static List<Bebida> Get()
        {
            return bebidas;
        }

        public static Bebida GetBebidaById(int id)
        {
            return bebidas.FirstOrDefault(l => l.Id == id);
        }

        public static void ModBebidaNameById(int id, string nome)
        {
            var bebida = BebidasRepository.GetBebidaById(id);
            bebida.Nome = nome;
        }

        public static void ModBebidaValorById(int id, decimal valor)
        {
            var bebida = BebidasRepository.GetBebidaById(id);
            bebida.Valor = valor;
        }

        public static void ModEstoqueValorById(int id, int estoque)
        {
            var bebida = BebidasRepository.GetBebidaById(id);
            bebida.Estoque = bebida.Estoque + estoque;
        }
    }
}
