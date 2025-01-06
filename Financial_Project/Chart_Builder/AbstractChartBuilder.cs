using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;
using ScottPlot.WinForms;

namespace Financial_Project.Chart_Builder
{
    public abstract class AbstractChartBuilder
    {
        public AbstractChartBuilder getInstance()
        {
            return this;
        }
        public void setData()
        {
            throw new NotImplementedException();
        }
        public void setDarkMode()
        {
            throw new NotImplementedException();
        }
        public abstract void processData();
        public abstract FormsPlot buildChart();
    }
}
