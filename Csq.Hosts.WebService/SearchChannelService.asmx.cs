using System;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MasterDuner.Cooperations.Csq.Channels;
using MasterDuner.Cooperations.Csq.Commons;

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
        #region CreateSession
        /// <summary>
        /// 创建会话标记。
        /// </summary>
        /// <returns><see cref="Guid"/>型的会话标记。</returns>
        [WebMethod(EnableSession = true)]
        public Guid CreateSession()
        {
            ISessionBinding binding = new SessionBinding();
            return binding.CreateSession();
        }
        #endregion

        #region Login
        /// <summary>
        /// 登录智联卓聘网。
        /// </summary>
        /// <param name="credentials">智联卓聘网身份凭据。</param>
        /// <param name="sessionID">会话标识。</param>
        /// <returns><see cref="Boolean"/>类型返回值。</returns>
        [WebMethod(EnableSession = true, MessageName = "HighpinCnLogin")]
        public AuthenticationResult Login(HPCredentials credentials, Guid sessionID)
        {
            IAuthenticationService authenService = new HPAuthenService(sessionID);
            return authenService.SignIn(SearchChannels.HighpinCn, credentials);
        }
        #endregion
    }
}
