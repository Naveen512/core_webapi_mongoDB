using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDBSample1.Model;

namespace MongoDBSample1.Repos
{
    public interface ILivingCreatureRepository
    {
        Task<IList<LivingCreature>> GetAll();
        Task AddCreature(LivingCreature creature);
        Task Update(LivingCreature creature);
        Task Delete(string id);
    }
}
