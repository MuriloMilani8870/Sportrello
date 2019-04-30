using System;

namespace Nosso_Trello.Utils {
    public class MenuUtil {
        /// <summary>Exibe as opçãos do usuário deslogado</summary>

        public static void MenuDeslogado () {
            Console.WriteLine ("--------------------------------");
            Console.WriteLine ("--------- Sportrello  ----------");
            Console.WriteLine ("------------ Menu --------------");
            Console.WriteLine ("|| (1) Cadastrar Usuário      ||");
            Console.WriteLine ("|| (2) Login                  ||");
            Console.WriteLine ("|| (0) Logout                 ||");
            Console.WriteLine ("--------------------------------");
            Console.WriteLine ("------ Escolha uma Opção -------");
        } //Fim do menu deslogado

        public static void MenuLogado(){
            Console.WriteLine ("--------------------------------");
            Console.WriteLine ("--------- Sportrello  ----------");
            Console.WriteLine ("------------ Menu --------------");
            Console.WriteLine ("|| (1) Cadastrar Tarefas      ||");
            Console.WriteLine ("|| (2) Listar Tarefas         ||");
            Console.WriteLine ("|| (0) Logout                 ||");
            Console.WriteLine ("--------------------------------");
            Console.WriteLine ("------ Escolha uma Opção -------");
        }// Fim do menu logado
    }
}