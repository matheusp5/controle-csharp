using LojaVirtualHx.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LojaVirtualHx.Helpers
{
    internal class Dashboard
    {
        public static void Inicio()
        {
            Program.Initialize();
            Console.WriteLine("     Seja bem-vindo a loja virtual.");
            Console.WriteLine("     O que deseja fazer:");

            Console.WriteLine("1.   Ver lanches.");
            Console.WriteLine("2.   Ver bebidas.");
            Console.WriteLine("3.   Sair.");

            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Dashboard.Lanches();
                    break;
                case 2:
                    Dashboard.Bebidas();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public static void Lanches()
        {
            Program.Initialize();
            var lanches = LanchesRepository.Get();
            Console.WriteLine("     Seja bem-vindo aos área dos lanches.");
            foreach(var l in lanches )
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("O que deseja fazer:");
            Console.WriteLine(" 1. Modificar nome");
            Console.WriteLine(" 2. Modificar valor");
            Console.WriteLine(" 3. Modificar estoque");
            Console.WriteLine(" 4. Retornar");

            var choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    ModificarNomeLanche();
                    break; 
                case 2:
                    ModificarValorLanche();
                    break;
                case 3:
                    ModificarEstoqueLanche();
                    break;
                case 4:
                    Dashboard.Inicio();
                    break;
            }
        }



        public static void Bebidas() 
        {
            Program.Initialize();
            var bebidas = BebidasRepository.Get();
            Console.WriteLine("     Seja bem-vindo aos área das bebidas.");
            foreach (var l in bebidas)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("O que deseja fazer:");
            Console.WriteLine(" 1. Modificar nome");
            Console.WriteLine(" 2. Modificar valor");
            Console.WriteLine(" 3. Modificar valor");
            Console.WriteLine(" 4. Retornar");

            var choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    ModificarNomeBebida();
                    break;
                case 2:
                    ModificarValorBebida();
                    break;
                case 3:
                    ModificarEstoqueBebida();
                    break;
                case 4:
                    Dashboard.Inicio();
                    break;
            }
        }


        public static void ModificarNomeBebida()
        {
            Program.Initialize();
            var bebidas = BebidasRepository.Get();
            Console.WriteLine("    Modifique o nome das bebidas");
            foreach (var l in bebidas)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Novo nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            BebidasRepository.ModBebidaNameById(id, nome);
            Console.WriteLine($"     O nome da bebida: {id} foi alterado para {nome}");


            Thread.Sleep(2500);
            Dashboard.Bebidas();

        }


        public static void ModificarValorBebida()
        {
            Program.Initialize();
            var bebidas = BebidasRepository.Get();
            Console.WriteLine("    Modifique o nome dos lanches");
            foreach (var l in bebidas)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Novo valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            BebidasRepository.ModBebidaValorById(id, valor);
            Console.WriteLine($"     O valor da bebida: {id} foi alterado para {valor}");


            Thread.Sleep(2500);
            Dashboard.Bebidas();

        }


        public static void ModificarEstoqueBebida()
        {
            Program.Initialize();
            var bebidas = BebidasRepository.Get();
            Console.WriteLine("    Modifique o estoque das bebidas");
            foreach (var l in bebidas)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor},estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Adicionar estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            BebidasRepository.ModEstoqueValorById(id, estoque);
            Console.WriteLine($"     O estoque da bebida: {id} foi adicionado {estoque}");


            Thread.Sleep(2500);
            Dashboard.Bebidas();

        }

        public static void ModificarNomeLanche() 
        {
            Program.Initialize();
            var lanches = LanchesRepository.Get();
            Console.WriteLine("    Modifique o nome dos lanches");
            foreach (var l in lanches)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Novo nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            LanchesRepository.ModLancheNameById(id, nome);
            Console.WriteLine($"     O nome do lanche: {id} foi alterado para {nome}");

            Thread.Sleep(2500);
            Dashboard.Lanches();

        }

        public static void ModificarValorLanche()
        {
            Program.Initialize();
            var lanches = LanchesRepository.Get();
            Console.WriteLine("    Modifique o nome dos lanches");
            foreach (var l in lanches)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Novo valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            LanchesRepository.ModLancheValorById(id, valor);
            Console.WriteLine($"     O valor do lanche: {id} foi alterado para {valor}");

            Thread.Sleep(2500);
            Dashboard.Lanches();
        }

        public static void ModificarEstoqueLanche()
        {
            Program.Initialize();
            var lanches = LanchesRepository.Get();
            Console.WriteLine("    Modifique o estoque dos lanches");
            foreach (var l in lanches)
            {
                Console.WriteLine($"    {l.Id}# {l.Nome}: {l.Valor}, estoque: {l.Estoque}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite 0 para retornar");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (id == 0) Dashboard.Lanches();

            Console.Write("Adicionar estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            LanchesRepository.ModLancheValorById(id, estoque);
            Console.WriteLine($"     O estoque do lanche: {id} foi adicionado {estoque}");

            Thread.Sleep(2500);
            Dashboard.Lanches();
        }
    }
}
