using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SuperHeroAppRepo.Entities
{
    [Table("SuperHero")]
    public class SuperHero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public string SuperHeroName { get; set; }
        public string Base64Img { get; set; }
        public ICollection<SuperHeroPower> Powers { get; set; }
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public List<string> StringPowers { get; set; }
    }
}
