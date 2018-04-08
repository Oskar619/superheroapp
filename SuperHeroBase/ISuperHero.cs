using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroBase
{
    public interface ISuperHero
    {
        string Name { get; }
        DateTime DateOfBirth { get; }
        List<string> Powers { get; }
    }
}
