using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IMasterService
    {
        List<MasterBM> GetList();

        MasterBM GetElement(int id);
    }
}
