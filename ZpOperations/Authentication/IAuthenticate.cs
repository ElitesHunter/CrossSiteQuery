#region "IAuthenticate"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 15:17:14
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Authentication
 * 
 * ####     Type Name : IAuthenticate
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Authentication.IAuthenticate
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


namespace MasterDuner.HHProjects.Csq.Highpincn.Authentication
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Authentication.IAuthenticate</para>
    /// <para>
    /// 卓聘网身份验证接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IAuthenticate
    {
        #region Credentials
        /// <summary>
        /// 设置或获取账户凭据。
        /// </summary>
        ISimulateCredentials Credentials { get; set; }
        #endregion

        #region ValidatingCode
        /// <summary>
        /// 设置或获取验证码。
        /// </summary>
        string ValidatingCode { get; set; }
        #endregion

        #region Logon
        /// <summary>
        /// 执行登录。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>登录是否成功。</returns>
        bool Logon(ISessionTag sessionTag);
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