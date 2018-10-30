using System;
using System.Collections.Generic;
using System.Text;

namespace Championship.Domain.Entities
{
    public class Match
    {
        public string Name { get; set; }

        public Team firstTeam { get; set; }

        public Team secondTeam { get; set; }

    }
}
