using SuperHeroAppRepo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]
    [XmlRoot(ElementName ="SuperHero")]
    public class SerializableSuperHero
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public DateTime BirthDate { get; set; }
        public List<SerializablePower> Powers { get; set; }
        public string ProfilePicture { get; set; }

        public SerializableSuperHero()
        {
            Powers = new List<SerializablePower>();
        }

        public SerializableSuperHero(SuperHero hero, bool includeImage = false)
        {
            Name = hero.Name;
            Alias = hero.SuperHeroName;
            BirthDate = hero.DateOfBirth;
            ProfilePicture = includeImage ? hero.Base64Img : "";
            Powers = new List<SerializablePower>();
            foreach(var power in hero.Powers)
            {
                var p = new SerializablePower();
                p.PowerName = power.PowerName;
                Powers.Add(p);
            }
        }
        
    }

    [Serializable]
    [XmlRoot(ElementName ="Power")]
    public class SerializablePower
    {
        public string PowerName { get; set; }
    }
}
