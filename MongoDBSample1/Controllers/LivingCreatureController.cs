using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBSample1.Model;
using MongoDBSample1.Repos;

namespace MongoDBSample1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivingCreatureController : ControllerBase
    {
        private readonly ILivingCreatureRepository _livingCreatureRepository;

        public LivingCreatureController(ILivingCreatureRepository livingCreatureRepository)
        {
            _livingCreatureRepository = livingCreatureRepository;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _livingCreatureRepository.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create(LivingCreature creature)
        {
            await _livingCreatureRepository.AddCreature(creature);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(LivingCreature creature)
        {
            await _livingCreatureRepository.Update(creature);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            await _livingCreatureRepository.Delete(id);
            return Ok();
        }
    }
}