using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IDiagrammaService
    {
        void MakeDiagramma();

        double CountProdGrop(int idGroup);

        void SaveDiagramma();
    }
}
