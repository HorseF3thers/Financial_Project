using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project
{
    public class API_Manager
    {
        private static API_Manager aMan;
        private API_Manager()
        {
            aMan = new API_Manager();
        }
        public static API_Manager GetInstance()
        {
            return aMan;
        }
        public void getFullHistorical(string ticker)
        {
            // Get full historical data
        }
        public void getShortHistorical(string ticker)
        {
            // Get short historical data
        }
        public void getIntraday(string ticker)
        {
            // Get intraday data
        }
        private string getApiKey()
        {
            // Get API key
            return "API_KEY";
        }
        public void setApiKey(string key)
        {
            // Set API key
        }
    }
}
