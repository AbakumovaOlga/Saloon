using BeautySaloonService.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IDirectoryService
    {
        void CalcTotalCost(MasterBM model); //расчет суммарной стоимости заключенных договоров для данного мастера в течение заданного периода с распределением по видам услуг

        void CalcAmountCosts(TypeProcedureBM model); //расчет суммы затрат в зависимости от вида оказанных услуг 
    }
}
