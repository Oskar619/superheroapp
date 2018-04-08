using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
