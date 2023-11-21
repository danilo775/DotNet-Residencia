namespace Pratica.NET_P002;

public class SistemaDeTarefas
{
    // Atributos privados
    private List<Tarefa> listaTarefasCriadas;
    private List<Tarefa> listaTarefasConcluidas;

    // Construtor
    public SistemaDeTarefas()
    {
        listaTarefasCriadas = new List<Tarefa>();
        listaTarefasConcluidas = new List<Tarefa>();
    }

    // Métodos de acesso (getters e setters)
    public List<Tarefa> GetListaTarefasCriadas()
    {
        return listaTarefasCriadas;
    }

    public void SetListaTarefasCriadas(List<Tarefa> novaListaTarefasCriadas)
    {
        listaTarefasCriadas = novaListaTarefasCriadas;
    }

    public List<Tarefa> GetListaTarefasConcluidas()
    {
        return listaTarefasConcluidas;
    }

    public void SetListaTarefasConcluidas(List<Tarefa> novaListaTarefasConcluidas)
    {
        listaTarefasConcluidas = novaListaTarefasConcluidas;
    }

    public void Criar tarefas
}
