using System;
using Nosso_Trello.Utils;
using Nosso_Trello.ViewController;
using Nosso_Trello.ViewModel;

namespace Nosso_Trello {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());
                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastra Os Usuarios
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        //Efetuar Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            Console.WriteLine ($"Seja bem vindo - {usuarioRecuperado.Nome}");
                            Console.ReadLine ();
                            do {
                                MenuUtil.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());
                                switch (opcaoLogado) {
                                    case 1:
                                    //Cadastrar Tarefas
                                    // TarefaViewController.CadastrarTarefa ();
                                        break;

                                    case 2:
                                    //Listar Tarefas
                                    // TarefaViewController.ListarTarefas ();
                                        break;

                                }
                            } while (opcaoLogado != 0);
                        }
                        break;
                    case 0:
                        //Fecha o programa
                        break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}