namespace Pratica.NET_P002;

using System;

public class Tarefa
{
    // Atributos privados
    private string titulo;
    private string descricao;
    private DateTime dataVencimento;

    // Construtor
    public Tarefa(string titulo, string descricao, DateTime dataVencimento)
    {
        this.titulo = titulo;
        this.descricao = descricao;
        this.dataVencimento = dataVencimento;
    }

    // Métodos de acesso (getters e setters)
    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string novoTitulo)
    {
        titulo = novoTitulo;
    }

    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string novaDescricao)
    {
        descricao = novaDescricao;
    }

    public DateTime GetDataVencimento()
    {
        return dataVencimento;
    }

    public void SetDataVencimento(DateTime novaDataVencimento)
    {
        dataVencimento = novaDataVencimento;
    }
}
