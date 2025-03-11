using System;
using System.ComponentModel.DataAnnotations;

namespace API_REVISAO.Models;

public class Produto
{
    [Key] // anotar [Key] faz ele reconhecer como chave primária
    public int Id { get; set; }
    public string? Nome { get; set; } // ? possibilita valores nulos
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; } // = Datetime.Now; pode ser feito diretamente sem construtor.

    public Produto ()
    {
        CriadoEm = DateTime.Now;
    }
}
