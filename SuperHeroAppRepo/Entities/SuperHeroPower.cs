using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroAppRepo.Entities
{
    [Table("SuperHeroPower")]
    public class SuperHeroPower
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("SuperHero")]
        public int SuperHeroId { get; set; }
        public string PowerName { get; set; }
        public SuperHero SuperHero { get; set; }
    }
}
