using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBSample1.Data;
using MongoDBSample1.Model;

namespace MongoDBSample1.Repos
{
    public class LivingCreatureRepository : ILivingCreatureRepository
    {
        private readonly IMongoCollection<LivingCreature> _livingCreatreCollction;
        public LivingCreatureRepository(IOptions<AppSettings> options, IMyWorldContext myWorldContext)
        {
            _livingCreatreCollction = myWorldContext.MyWorldDb.GetCollection<LivingCreature>(options.Value.LivingCreatureCollection);
        }

        public async Task<IList<LivingCreature>> GetAll()
        {
            return await _livingCreatreCollction.Find(_ => true).ToListAsync();
        }

        public async Task AddCreature(LivingCreature creature)
        {
            await  _livingCreatreCollction.InsertOneAsync(creature);
        }

        public async Task Update(LivingCreature creature)
        {
            await _livingCreatreCollction.ReplaceOneAsync(_ => _.Id == creature.Id, creature);
        }

        public async Task Delete(string id)
        {
            await _livingCreatreCollction.DeleteOneAsync(_ => _.Id == id);
        }
    }
}
