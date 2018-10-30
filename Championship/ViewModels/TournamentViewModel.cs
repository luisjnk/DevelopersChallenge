﻿using Championship.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Championship.ViewModels
{
    public class TournamentViewModel
    {   //[Key]
        public Guid TournamentId { get; set; }

        [Required(ErrorMessage = "Please, fill the field Name")]
        [MaxLength(100, ErrorMessage = "Name can't be greater than  {0} characters ")]
        [MinLength(5, ErrorMessage = "Name can't be less  than  {0} characters ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, fill the field TeamsCount")]
        public List<TeamViewModel> Teams;

        public int NumberOfKeys { get; set; }

        public List<KeyViewModel> keys { get; set; }

        public List<MatchViewModel> matches { get; set; }
        
    }

}