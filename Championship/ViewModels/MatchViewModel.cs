using Championship.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class MatchViewModel
    {   //[Key]
        
        public string Name { get; set; }

        public Team firstTeam;

        public Team secondTeam;
        
    }

}