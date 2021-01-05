using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaFacture.Interface
{
    public class IContactRepository
    {
        IEnumerable<DTO.User> GetAll();
        DTO.User GetOne(int id);
        int Insert(DTO.User u);
        void Update(DTO.User u);
        bool Delete(int id);
    }
}
