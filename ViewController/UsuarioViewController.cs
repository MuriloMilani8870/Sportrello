using System;
using Nosso_Trello.Repositorio;
using Nosso_Trello.Utils;
using Nosso_Trello.ViewModel;

namespace Nosso_Trello.ViewController {
    public class UsuarioViewController {
        //Instanciar o repositorio

        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadastrarUsuario () {
            string nome, email, senha, tipo, confirmaSenha;
            do {
                Console.WriteLine ("Digite o nome do Usuário");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    Console.WriteLine ("Nome inválido");
                } //fim if
            } while (string.IsNullOrEmpty (nome));

            do {
                Console.WriteLine ("Digite o email do usuário");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {

                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                Console.WriteLine ("Digite a senha do usuario");
                senha = Console.ReadLine ();

                Console.WriteLine ("Confirme a senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha)) {
                    Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha));

            //Cria um objeto do tipo usuario

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Método para inserir no banco de dados

            usuarioRepositorio.Inserir (usuarioViewModel);

            Console.WriteLine ("Cadastro efetuado com sucesso");
        } //Fim cadastrar usuario

        internal static UsuarioViewModel EfetuarLogin()
        {
            throw new NotImplementedException();
        }
    }
}