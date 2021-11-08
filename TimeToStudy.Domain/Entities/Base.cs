using System;

namespace TimeToStudy.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}