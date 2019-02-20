using BeautySaloonModel;
using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IMainService
    {
        List<ClientBM> FindClient(string number); //поиск по номеру договора или по номеру паспорта

        List<ClientBM> SelectionClientData(ProcedureBM model); //выборка данных о клиентах, заключивших договора на оказание определенного вида услуги

        List<ClientBM> SelectionListClient(); //выборка списка клиентов наиболее часто обращающихся за услугами???

        void Archive();

        User Authorisation(string login, string password);
    }
}
