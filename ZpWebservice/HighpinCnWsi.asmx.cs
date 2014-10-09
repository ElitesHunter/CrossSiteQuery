using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MasterDuner.HHProjects.Csq.Highpincn.Authentication;
using MasterDuner.HHProjects.Csq.Highpincn.Parameters;
using MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode;

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
        [WebMethod(Description = "执行第一步，请求卓聘网的首页数据。<br />sessionTag:客户端会话标记。")]
        public string PerformFirstStep(ClientSessionTag sessionTag)
        {
            return new ZpHomePageRequestHandler().RequestAndGetResponseData(new ZpHomePageRequest(sessionTag) { Method = HttpMethods.Get });
        }
        #endregion

        #region RequestValidatingCode
        /// <summary>
        /// 请求验证码。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>验证码。</returns>
        [WebMethod(Description = "向卓聘网申请验证码。<br />sessionTag:客户端会话标记。")]
        public string RequestValidatingCode(ClientSessionTag sessionTag)
        {
            return new ValidatingCodeHttpRequestHandler().RequestAndGetResponseData(new ZpValidatingCodeHttpRequest(sessionTag) { Method = HttpMethods.Get });
        }
        #endregion

        #region TryLogon
        /// <summary>
        /// 尝试登录卓聘网。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="validatingCode">验证码。</param>
        /// <returns>是否登录成功。</returns>
        [WebMethod(Description = "尝试使用模拟账户登录卓聘网。<br />sessionTag:会话标记。<br />validatingCode:验证码。")]
        public bool TryLogon(ClientSessionTag sessionTag, string validatingCode)
        {
            return new ZpLogonHttpRequestHandler()
            {
                Credentials = StaticUserCredentials.Current,
                ValidatingCode = validatingCode
            }.Logon(sessionTag);
        }
        #endregion

        #region TryGetIndustryData
        /// <summary>
        /// 尝试获取卓聘网的行业数据。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>行业数据。</returns>
        [WebMethod(Description = "尝试向卓聘网请求行业数据。<br />sessionTag:会话标记。")]
        public IndustryCollection TryGetIndustryData(ClientSessionTag sessionTag)
        {
            return new IndustryDataHelper() { SessionTag = sessionTag }.GetData();
        }
        #endregion
    }
}
