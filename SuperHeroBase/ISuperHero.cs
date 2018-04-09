using System;
using System.Collections.Generic;

namespace SuperHeroBase
{
    public interface ISuperHero
    {
        string Name { get; }
        DateTime DateOfBirth { get; }
        List<string> Powers { get; }
    }
}
