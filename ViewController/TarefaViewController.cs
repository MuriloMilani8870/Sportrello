using System;
using System.Collections.Generic;
using Nosso_Trello.Repositorio;
using Nosso_Trello.Utils;
using Nosso_Trello.ViewModel;

namespace Nosso_Trello.ViewController {
    public class TarefaViewController {
        //Instanciar o repositorio 

        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio ();

        public static void CadastrarTarefa () {
            string nomeTarefa, descricaoTarefa;
            int tipoTarefa , idusuario;
            // string tipoTarefa;
            do {
                Console.WriteLine ("Digite o nome da Tarefa");
                nomeTarefa = Console.ReadLine ();
                if (string.IsNullOrEmpty (nomeTarefa)) {
                    Console.WriteLine ("Nome inválido");
                } //fim if

            } while (string.IsNullOrEmpty (nomeTarefa));
            do {
                Console.WriteLine ("Digite a descrição da Tarefa");
                descricaoTarefa = Console.ReadLine ();
                if (string.IsNullOrEmpty (descricaoTarefa)) {
                    Console.WriteLine ("Descrição inválido");
                } //fim if

            } while (string.IsNullOrEmpty (descricaoTarefa));

             do {
                Console.WriteLine ("Digite o ID de quem fará a tarefa");
                idusuario = int.Parse(Console.ReadLine ());
                if (idusuario == 0) {
                    Console.WriteLine ("ID inválido");
                } //fim if

            } while (idusuario == 0);

            do {
                //  ME : Fazer o menu do tipo da Tarefa
                Console.WriteLine ("--------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine ("----------- Opções -------------");
                Console.ResetColor ();
                Console.WriteLine ("--------------------------------");
                Console.WriteLine ("|| (1) Para fazer             ||");
                Console.WriteLine ("|| (2) Fazendo                ||");
                Console.WriteLine ("|| (3) Feito                  ||");
                Console.WriteLine ("--------------------------------");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine ("Digite o número correspondente a categoria da tarefa");
                Console.ResetColor ();
                tipoTarefa = int.Parse (Console.ReadLine ());

                switch (tipoTarefa) {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("Tarefa cadastrada como 'A Fazer'");
                        Console.ResetColor ();
                        tipoTarefa = int.Parse (Console.ReadLine ());
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("Tarefa cadastrada como 'Fazendo'");
                        Console.ResetColor ();
                        tipoTarefa = int.Parse (Console.ReadLine ());

                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("Tarefa cadastrada como 'Feita'");
                        Console.ResetColor ();
                        tipoTarefa = int.Parse (Console.ReadLine ());

                        break;
                }
            } while (tipoTarefa == null);

            TarefaViewModel TarefaViewModel = new TarefaViewModel ();
            TarefaViewModel.Nome = nomeTarefa;
            TarefaViewModel.Descricao = descricaoTarefa;
            TarefaViewModel.Tipo = tipoTarefa;
            TarefaViewModel.IdUsuario = idusuario;

            tarefaRepositorio.AdicionarTarefa (TarefaViewModel);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("Tarefa cadastrada com sucesso!");
            Console.ResetColor ();

        }
        public static void ListarTarefas () {
            List<TarefaViewModel> ListadeTarefas = tarefaRepositorio.Listar ();
            foreach (var item in ListadeTarefas) {
                System.Console.WriteLine ("-----------------------------------------------------");
                System.Console.WriteLine ($"ID: {item.Id}");
                System.Console.WriteLine ($"Id do Usuário responsável: {item.IdUsuario}");
                System.Console.WriteLine ($"Nome da Tarefa: {item.Nome}");
                System.Console.WriteLine ($"Descrição da Tarefa: {item.Descricao}");
                if (item.Tipo == 1) {
                    System.Console.WriteLine ($"Categoria da Tarefa é 'A Fazer'");

                } else if (item.Tipo == 2) {
                    System.Console.WriteLine ($"Categoria da Tarefa é 'Fazendo'");                    
                } 
                else if (item.Tipo == 3) {
                    System.Console.WriteLine ($"Categoria da Tarefa é 'Feito'");
                    
                }
                System.Console.WriteLine ($"Tarefa cadastrada em: {item.DataCriacao}");
                System.Console.WriteLine ("-----------------------------------------------------");
            }
            Console.ReadLine ();
        }
    }
}