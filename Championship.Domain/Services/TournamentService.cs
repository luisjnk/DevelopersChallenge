using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Championship.Domain.Services
{
    public class TournamentService : ServiceBase<Tournament>, ITournamenteService
    {
        public readonly ITournamentRepository _tournamentRepository;

        public  TournamentService(ITournamentRepository tournamentRepository)
            :base(tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        public void CreateTournament(Tournament tournament, string uri)
        {
            int countOfTournamentKeys = ValidateTournament(tournament);
            if (countOfTournamentKeys > 0)
            {
                tournament.NumberOfKeys = countOfTournamentKeys;
                Tournament tournamentWithKeys = CreateKeys(tournament);
                _tournamentRepository.Add(tournamentWithKeys, uri);
            } else
            {

            }
        }

        public Task<Tournament> GetTournament(string uri)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The Tournament need to be in championship rules
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns>tou</returns>
        private int ValidateTournament(Tournament tournament)
        { 
            int rest = tournament.Teams.Count & 2;
            if(rest == 0)
            {
                return tournament.Teams.Count / 4;
            } else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// Creating keys for the tournament
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        private Tournament CreateKeys(Tournament tournament)
        {
            int index = 0;
            Key key;
            List<Team> teams = new List<Team>();
            foreach (Team team in tournament.Teams)
            {
                teams.Add(team);;
                bool keyIsFull = (index % 4) == 0;
                if (keyIsFull)
                {   key = new Key();
                    key.Teams = teams;
                    tournament.Keys.Add(key);
                    teams = new List<Team>();
                }
                index++;

            }
            return tournament;
        }

        private Tournament CreateMatches(Tournament tournament)
        {
            int index = 0;
            Key key;
            List<Team> teams = new List<Team>();
            foreach (Team team in tournament.Teams)
            {
                teams.Add(team); 
                bool keyIsFull = (index % 4) == 0;
                if (keyIsFull)
                {
                    key = new Key();
                    key.Teams = teams;
                    tournament.Keys.Add(key);
                    teams = new List<Team>();
                }
                index++;

            }
            return tournament;
        }
    }
}
