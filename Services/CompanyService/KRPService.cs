using CursTest.Data;
using CursTest.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public class KRPService:IKRPService
    {
        private readonly IMongoCollection<KRP> _krp;
        public KRPService(IDbClient dbClient)
        {
            _krp = dbClient.GetKRPCollection();
        }
        public List<KRP> GetKRPs()//This method going to return list krp
        {
            return _krp.Find(x => true).ToList();
            //return _krp.Find(new KRP()).ToList();
        }
        public KRP GetKRP(string id)
        {
            return _krp.Find(krp => krp.id == id).First();
        }
    }
}
