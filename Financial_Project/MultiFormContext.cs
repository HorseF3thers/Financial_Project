using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project
{
    public class MultiFormContext : ApplicationContext
    {
        public MultiFormContext(Main_Menu_Form mainForm)
        {
            CreateAndShowForm(mainForm);
        }
        private static void CreateAndShowForm(Main_Menu_Form form)
        {
            if(form.InvokeRequired)
            {
                form.Invoke(new MethodInvoker(() => form.ShowDialog()));
            }
            else
            {
                form.ShowDialog();
            }
        }
    }
}
