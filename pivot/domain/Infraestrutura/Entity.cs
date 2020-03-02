using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pivot.Domain.Infraestrutura
{
    public class Entity
    {
        [Key]
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public int UsuarioCriacaoId { get; set; }
        public string UsuarioCriacaoLogin { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int UsuarioAlteracaoId { get; set; }
        public string UsuarioAlteracaoLogin { get; set; }

        [DefaultValue(true)]
        public bool Ativo { get; set; }
    }
}
