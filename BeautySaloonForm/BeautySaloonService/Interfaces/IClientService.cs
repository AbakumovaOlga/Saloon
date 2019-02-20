using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IClientService
    {
        void AddClient(ClientBM model);

        void UpdClient(ClientBM model);

        void DelClient(ClientBM model);

        List<ClientBM> GetList();

        ClientBM GetElement(int id);
    }
}
