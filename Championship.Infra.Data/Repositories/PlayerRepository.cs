using System.Collections.Generic;
using Championship.Domain.Entities;
using Championship.Domain.Interfaces;

namespace Championship.Infra.Data.Repositories
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
    {   
        public PlayerRepository()
        {
            this.Connect();
        }
        public IEnumerable<Team> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }

    }
}
