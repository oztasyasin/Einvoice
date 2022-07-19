using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Abstract
{
    public interface IClientService
    {
        List<Client> GetAll();
        Client GetByName(string name);
        Client GetById(int id);
        Client GetByCode(string code);
        void Add(Client client);
        void Delete(Client client);
        void Update(Client client);
    }
}
