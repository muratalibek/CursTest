using CursTest.Models;
using System.Collections.Generic;

namespace CursTest.Services.CompanyService
{
    public interface IKRPService
    {
        List<KRP> GetKRPs();
        KRP GetKRP(string id);
    }
}
