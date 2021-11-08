using System;

namespace TimeToStudy.Domain.Entities
{
    public class Revisao : Base
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
    }
}