using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuProjeto
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void CriarTarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            Tarefa tarefa = new Tarefa
            {
                Titulo = titulo,
                Descricao = descricao,
                DataVencimento = dataVencimento,
                Concluida = false
            };
            tarefas.Add(tarefa);
        }

        public List<Tarefa> ListarTarefas()
        {
            return tarefas;
        }

        public void MarcarTarefaComoConcluida(Tarefa tarefa)
        {
            tarefa.Concluida = true;
        }

        public List<Tarefa> ListarTarefasPendentes()
        {
            return tarefas.Where(t => !t.Concluida).ToList();
        }

        public List<Tarefa> ListarTarefasConcluidas()
        {
            return tarefas.Where(t => t.Concluida).ToList();
        }

        public void ExcluirTarefa(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public List<Tarefa> PesquisarTarefas(string palavraChave)
        {
            return tarefas.Where(t => t.Titulo.Contains(palavraChave) || t.Descricao.Contains(palavraChave)).ToList();
        }

        public int NumeroTarefasConcluidas()
        {
            return tarefas.Count(t => t.Concluida);
        }

        public int NumeroTarefasPendentes()
        {
            return tarefas.Count(t => !t.Concluida);
        }

        public Tarefa TarefaMaisAntiga()
        {
            return tarefas.OrderBy(t => t.DataVencimento).FirstOrDefault();
        }

        public Tarefa TarefaMaisRecente()
        {
            return tarefas.OrderByDescending(t => t.DataVencimento).FirstOrDefault();
        }
    }
}