using System;
using System.Collections.Generic;

namespace Championship.Domain.Entities
{
    public class Tournament
    {
        public Guid TournamentId { get; set; }

        public string Name { get; set; }

        public List<Team> Teams { get; set; }

        public int NumberOfKeys { get; set; }

        public List<Key> Keys { get; set; }

        public List<Match> Matches { get; set; }

        public void genId()
        {
            this.TournamentId = Guid.NewGuid();
        }

    }
}
