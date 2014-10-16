using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MasterDuner.Cooperations.Csq.Application.WebServices
{
    /// <summary>
    /// 搜索渠道：简历搜索WEB服务接口。
    /// </summary>
    [WebService(Namespace = "urn:MasterDuner@Yeah.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class SearchChannelService : WebService
    {
    }
}
