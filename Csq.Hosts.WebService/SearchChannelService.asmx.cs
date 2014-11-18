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
        public HPAuthenResult Login(HPCredentials credentials, Guid sessionID)
        {
            IAuthenticationService authenService = new HPAuthenService(sessionID);
            return authenService.SignIn(SearchChannels.HighpinCn, credentials) as HPAuthenResult;
        }
        #endregion

        #region Search
        /// <summary>
        /// 搜索智联卓聘网的简历。
        /// </summary>
        /// <param name="sessionID">会话标记。</param>
        /// <param name="searchParams">搜索参数。</param>
        /// <param name="paging">分页信息。</param>
        /// <returns>搜索结果。</returns>
        [WebMethod(EnableSession = true, MessageName = "HighpinCnSearch")]
        public HPSearchResult Search(Guid sessionID, HPRequirement searchParams, ResultPage paging)
        {
            IResumeSearcher service = new HPResumeSearcher();
            return service.Get(sessionID, SearchChannels.HighpinCn, searchParams, paging) as HPSearchResult;
        }
        #endregion

        #region ViewResume
        /// <summary>
        /// 查看智联卓聘网的简历详情。
        /// </summary>
        /// <param name="detailsUrl">简历详情URL地址。</param>
        /// <param name="sessionID">会话标识。</param>
        /// <returns>简历的HTML字符串表达式。</returns>
        [WebMethod(EnableSession = true, MessageName = "HighpinCnDetails")]
        public string ViewResume(string detailsUrl, Guid sessionID)
        {
            IResumeViewerService service = new HPResumeViewerService();
            return service.GetResumeHtml(new ResumeDetailViewerArgs() { DetailPageUrl = detailsUrl }, sessionID);
        }
        #endregion
    }
}
