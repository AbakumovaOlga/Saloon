using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface ICommissionService
    {
        void AddCommission(CommissionBM model);

        void UpdCommission(CommissionBM model);

        void DelCommission(CommissionBM model);

        List<CommissionBM> GetList();

        CommissionBM GetElement(int id);
    }
}
