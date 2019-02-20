using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IContractService
    {
        void AddContract(ContractBM model);

        void UpdContract(ContractBM model);

        void DelContract(ContractBM model);

        List<ContractBM> GetList();

        ContractBM GetElement(int id);
    }
}
