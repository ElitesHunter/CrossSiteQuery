#region "IAuthenticationService"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 9:51:44
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : IAuthenticationService
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.IAuthenticationService
 * 
 * ####     Machine Name : GLCHQWYCWINW7
 * 
 * ####     UserName : GUOCOLAND/wangyucai
 * 
 * ####     CLR Version : 4.0.30319.18444
 * 
 * ####     Target Framework Version : 4.0
 */

#endregion

using System.ServiceModel;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.IAuthenticationService</para>
    /// <para>
    /// 搜索渠道身份认证接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [ServiceContract]
    public interface IAuthenticationService
    {
        #region SignIn
        /// <summary>
        /// 登录到指定的搜索渠道。
        /// </summary>
        /// <param name="channel">搜索渠道标记。</param>
        /// <param name="credentials">搜索渠道身份凭据。</param>
        /// <returns>身份认证结果对象实例。</returns>
        AuthenticationResult SignIn(SearchChannels channel, SearchChannelCredentials credentials);
        #endregion
    }
}

#region README

/*
 * ####     ©2014 Wang Yucai
 * 
 * ####     Contact me
 *                  
 *                  E-mail : Masterduner@Yeah.net
 *                  Mobile : 13621384677
 *                  QQ : 180261899
 */

#endregion