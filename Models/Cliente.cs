using Crud.Enum;
using System;

namespace Crud.Models
{
public class Cliente
    {
        public int Id { get; set; }
        public string Lugar { get; set; }
        public int preco { get; set; }
        public int Tempo { get; set; }
        public Situacao Situacao { get; set; }



    }
}