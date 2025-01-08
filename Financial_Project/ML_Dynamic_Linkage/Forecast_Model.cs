using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.ML_Dynamic_Linkage
{
    public class Forecast_Model : AbstractMLProgram
    {
        public override void start()
        {
            MethodInfo mi = getEnvironment().loadModel();
            getEnvironment().buildForecast(mi);
        }
    }
}
