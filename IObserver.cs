using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedeminBasesManager
{
    public interface IObserver
    {
        void Update(string Value);
        bool InvokeRequired();
        void clear();
    }
}
