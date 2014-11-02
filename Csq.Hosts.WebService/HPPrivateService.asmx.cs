using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MasterDuner.Cooperations.Csq.Channels;

namespace MasterDuner.Cooperations.Csq.Application.WebServices
{
    /// <summary>
    /// 智联卓聘网私有服务。
    /// </summary>
    [WebService(Namespace = "urn:MasterDuner@Yeah.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class HPPrivateService : System.Web.Services.WebService
    {
        #region ParseTheSearchResultHtml
        /// <summary>
        /// 解析搜索结果HTML文本内容。
        /// </summary>
        /// <param name="html">HTML搜索结果文本内容。</param>
        /// <returns><see cref="SearchResultObject"/>对象实例集合。</returns>
        [WebMethod]
        public List<SearchResultObject> ParseTheSearchResultHtml(string html)
        {
            IHtmlParser service = new HPResultHtmlParser();
            return service.ParseHtml(html);
        }
        #endregion
    }
}
