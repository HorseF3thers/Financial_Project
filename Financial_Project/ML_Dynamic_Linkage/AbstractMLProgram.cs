using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.ML_Dynamic_Linkage
{
    public abstract class AbstractMLProgram
    {
        private ML_choice environment;

        public void setEnvironment(ML_choice environment)
        {
            this.environment = environment;
        }
        public ML_choice getEnvironment()
        {
            return environment;
        }
        abstract public void start();
    }
}
