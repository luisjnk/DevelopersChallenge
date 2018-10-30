using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using System.Collections.Generic;

namespace Championship.Infra.Data.Repositories
{
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public IEnumerable<Team> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
