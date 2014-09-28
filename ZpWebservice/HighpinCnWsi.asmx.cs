using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.ComponentModel;

namespace MasterDuner.HHProjects.Csq.Highpincn.Wsi
{
    /// <summary>
    /// 智联卓聘网跨站查询WEB服务接口。
    /// </summary>
    [WebService(Namespace = "http://www.highpin.cn", Description = "智联卓聘网跨站查询WEB服务接口。<br /><br />此服务允许JavaScript进行访问。")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class HighpinCnWsi : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
