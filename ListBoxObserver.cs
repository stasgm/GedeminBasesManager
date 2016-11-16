using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GedeminBasesManager
{
    class ListBoxObserver : IObserver
    {
        private TextBox lbox;
        public ListBoxObserver(TextBox newlbox)
        {
            lbox = newlbox;
        }
        public void Update(string Value)
        {
            lbox.Text += Value;
        }
        public bool InvokeRequired()
        {
            return lbox.InvokeRequired;
        }
        public void clear()
        {
            lbox.Clear();
        }
    }
}
