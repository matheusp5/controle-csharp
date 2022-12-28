using LojaVirtualHx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualHx.Repositories
{
    internal class LanchesRepository
    {
        static List<Lanche> lanches = new List<Lanche>()
        {
            new Lanche() { Id = 1, Nome = "X-Tudo", Valor = 23, Estoque = 2 },
            new Lanche() { Id = 2, Nome = "X-Cheddar", Valor = 13, Estoque = 4 },
            new Lanche() { Id = 3, Nome = "X-Burguer", Valor = 9, Estoque = 3 },
        };

        public static List<Lanche> Get() 
        {
            return lanches;
        }

        public static Lanche GetLancheById(int id)
        {
            return lanches.FirstOrDefault(l => l.Id == id);
        }


        public static void ModLancheNameById(int id, string nome)
        {
            var lanche = LanchesRepository.GetLancheById(id);
            lanche.Nome = nome;
        }

        public static void ModLancheValorById(int id, decimal valor)
        {
            var lanche = LanchesRepository.GetLancheById(id);
            lanche.Valor = valor;
        }
        public static void ModEstoqueLancheById(int id, int estoque)
        {
            var lanche = LanchesRepository.GetLancheById(id);
            lanche.Estoque = lanche.Estoque + estoque;
        }
    }
}
