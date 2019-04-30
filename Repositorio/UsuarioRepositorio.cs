using System;
using System.Collections.Generic;
using Nosso_Trello.ViewModel;

namespace Nosso_Trello.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> ListaDeUsuarios = new List<UsuarioViewModel>();
        /// <summary>Método responsável por armazenar um usúario</summary>

        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = ListaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            //Insere o objeto usuario dentro da lista
            ListaDeUsuarios.Add(usuario);

            return usuario;
        }
        /// <summary>Retorna lista de usuario</summary>

        public List<UsuarioViewModel> Listar(){
            return ListaDeUsuarios;
        }//fim listar
    }
}