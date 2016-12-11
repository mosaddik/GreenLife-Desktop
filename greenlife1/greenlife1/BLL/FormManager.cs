using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenlife1.BLL
{
    class FormManager
    {
        public void DisposeAllButThis(Form form , MDIParent1 mdi)
        {
            foreach (Form frm in mdi.MdiChildren)
            {
                if ( frm != form)
                {
                    frm.Close();
                }
            }
        }
    }
}
