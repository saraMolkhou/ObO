using clean.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.core.Repositories
{
    public interface IOrderRepository
    {
        List<order> GetList();
        order GetById(int oNum);
        void Add(order ord);
        void Update(order order, int oNum);
    }
}
