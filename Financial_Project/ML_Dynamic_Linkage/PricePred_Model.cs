using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.ML_Dynamic_Linkage
{
    public class PricePred_Model : AbstractMLProgram
    {
        public override void start()
        {
            MethodInfo methodInfo = getEnvironment().loadModel();
            getEnvironment().buildPredication(methodInfo);
        }
    }
}
