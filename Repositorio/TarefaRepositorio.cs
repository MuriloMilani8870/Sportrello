using System;
using System.Collections.Generic;
using Nosso_Trello.ViewModel;

namespace Nosso_Trello.Repositorio {
    public class TarefaRepositorio{
        List<TarefaViewModel> ListadeTarefas = new List<TarefaViewModel> ();

        /// <summary>Método responsável por armazenar uma tarefa</summary>>

        public TarefaViewModel AdicionarTarefa(TarefaViewModel tarefa) {
            tarefa.Id = ListadeTarefas.Count + 1;
            tarefa.DataCriacao = DateTime.Now;
            //Insere o objeto tarefa dentro da lista    
            ListadeTarefas.Add (tarefa);

            return tarefa;
        }

        public List<TarefaViewModel> Listar() {
            return ListadeTarefas;
        }
    }
}