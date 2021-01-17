using System;
using System.ComponentModel.DataAnnotations;

namespace LitLiterary.Lib.Shared.Models
{
    public class DomainObject
    {
        [Key]
        public Guid Id { get; set; }
    }
}