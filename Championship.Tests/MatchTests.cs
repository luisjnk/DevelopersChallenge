using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Championship.Domain.Entities;
using Championship.Domain.Models;

namespace Championship.Tests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void RunMatch()
        {
            //Arange
            Team firstTeam = new Team();
            firstTeam.Name = "First Team";

            //ACT       
            Team secondTeam = new Team();
            secondTeam.Name = "Second Team";

            MatchModel match = new MatchModel();

            Team team = match.StartMatch(firstTeam, secondTeam);
            //Assert
            Assert.AreEqual(1, 1);
        }
        
    }
}
