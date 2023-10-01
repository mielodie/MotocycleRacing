using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorcycleRacing.Entities
{
    public class MotoGP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rider { get; set; }
        public int? Leader { get; set; }
        public int? Previous { get; set; }
        public int? Point { get; set; }
        public string? Nationality { get; set; }
        public int? AME { get; set; }
        public int? ARA { get; set; }
        public int? ARG { get; set; }
        public int? AUS { get; set; }
        public int? AUT { get; set; }
        public int? CAT { get; set; }
        public int? FRA { get; set; }
        public int? GBR { get; set; }
        public int? GER { get; set; }
        public int? INA { get; set; }
        public int? ITA { get; set; }
        public int? JPN { get; set; }
        public int? MAL { get; set; }
        public int? NED { get; set; }
        public int? POR { get; set; }
        public int? QAT { get; set; }
        public int? RSM { get; set; }
        public int? SPA { get; set; }
        public int? THA { get; set; }
        public int? VAL { get; set; }
    }
}
