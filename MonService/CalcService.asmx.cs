using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MonService
{
    /// <summary>
    /// Summary description for CalcService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Message()
        {
            return "Merci de nous avoir suivi";
        }
        [WebMethod]
        public decimal Plus(decimal a, decimal b) => a + b;
        
        [WebMethod]
        public decimal Moins(decimal a, decimal b) => a - b;

        [WebMethod]
        public decimal Multiplier(decimal a, decimal b) => a * b;

        [WebMethod]
        public decimal Diviser(decimal a, decimal b) => a / b;
    }
}
