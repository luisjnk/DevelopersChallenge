﻿using AutoMapper;
using Championship.Application.Interfaces;
using Championship.Domain.Entities;
using Championship.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Championship.Controllers
{
    public class TournamentController : ApiController
    {
        private  ITournamentAppService _tournamentAppService;

        public TournamentController(ITournamentAppService tournamentAppService)
        {
            _tournamentAppService = tournamentAppService;
        }

        [HttpGet]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public TournamentViewModel Post([FromBody]TournamentViewModel tournament) {
            try
            {
                Tournament tournamentDomain = Mapper.Map<TournamentViewModel, Tournament>(tournament);
                tournamentDomain.genId();
                _tournamentAppService.CreateTournament(tournamentDomain);
               
                return tournament;
            }
            catch (Exception ex)
            {
                throw;
            }
          }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        [Route("api/tournament/keys/generate")]
        public IEnumerable<string> PostTournament()
        {
            return new string[] { "value1", "value2" };
        }
    }
}