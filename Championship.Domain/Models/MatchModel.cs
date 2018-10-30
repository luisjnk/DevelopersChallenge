using Championship.Domain.Entities;
using System;

namespace Championship.Domain.Models
{
   public class MatchModel
    {
        public Team ManageMatch(Team firstTeam, Team secondTeam)
        {
            Team winner = StartMatch(firstTeam,secondTeam);
            return winner;
        } 

       public Team StartMatch(Team firstTeam, Team secondTeam)
        {
            Team[] match = new Team[2];
            match[0] = firstTeam;
            match[1] = secondTeam;

            int[] firstArray = new int[] { 1, 0 };
            int[] secondArray = new int[] { 0, 1 };

            for (int i = 0; i <= 1; i++)
            {
                secondArray[i] = i;
                firstArray[i] = i;
            }

            Array.Sort(firstArray, secondArray);
            Team winner = match[0];
            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for (int t = 0; t < firstArray.Length; t++)
            {
                if (firstArray[t] == secondArray[t])
                {
                        winner = match[t];
                 }
                
            }

            return winner;
        }
        
        
    }
}
