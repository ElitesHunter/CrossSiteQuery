using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MasterDuner.HHProjects.Csq.Highpincn.Wsi
{
    /// <summary>
    /// 智联卓聘网跨站查询WEB服务接口。
    /// </summary>
    [WebService(Namespace = "http://www.highpin.cn", Description = "智联卓聘网跨站查询WEB服务接口。<br /><br />此服务允许JavaScript进行访问。")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class HighpinCnWsi : WebService
    {
        #region RequestSessionTag
        /// <summary>
        /// 请求一个会话标记。
        /// </summary>
        /// <returns><see cref="ClientSessionTag"/>对象实例。</returns>
        [WebMethod(Description = "请求一个会话标记。", EnableSession = true)]
        public ClientSessionTag RequestSessionTag()
        {
            return ClientSessionTag.CreateSessionTag();
        }
        #endregion

        #region PerformFirstStep
        /// <summary>
        /// 发送HTTP请求，并获取卓聘网首页数据。
        /// </summary>
        /// <param name="sessionTag">会话标记数据。</param>
        /// <returns>卓聘网首页HTML字符串表达式。</returns>
        [WebMethod(Description="执行第一步，请求卓聘网的首页数据。<br />sessionTag:客户端会话标记。")]
        public string PerformFirstStep(ClientSessionTag sessionTag)
        {
            return new ZpHomePageRequestHandler().RequestAndGetResponseData(new ZpHomePageRequest(sessionTag));
        }
        #endregion
    }
}
