using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Business.Abstract;
using Invoice.DataAccess.Abstract;
using Invoice.Entites.Concrete;

namespace Invoice.Business.Concrete
{
    public class ClientManager : IClientService
    {
        private IClientDal _clientDal;

        public ClientManager(IClientDal clientDal)
        {
            _clientDal = clientDal;
        }
        public void Add(Client client)
        {
            _clientDal.Add(client);
        }

        public void Delete(Client client)
        {
            _clientDal.Delete(client);
        }

        public List<Client> GetAll()
        {
            return _clientDal.GetList();
        }

        public Client GetByCode(string code)
        {
            return _clientDal.Get(p => p.Code == code);
        }

        public Client GetById(int ClientId)
        {
            return _clientDal.Get(p => p.Id == ClientId);
        }

        public Client GetByName(string name)
        {
            return _clientDal.Get(p => p.Name == name);
        }

        public void Update(Client client)
        {
            _clientDal.Update(client);
        }
    }
}
