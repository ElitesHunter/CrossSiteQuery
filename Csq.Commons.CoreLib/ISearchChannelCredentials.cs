#region "ISearchChannelCredentials"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 9:51:07
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : ISearchChannelCredentials
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.ISearchChannelCredentials
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


namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.ISearchChannelCredentials</para>
    /// <para>
    /// 合法的搜索渠道身份凭据接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ISearchChannelCredentials
    {
        #region UserName
        /// <summary>
        /// 设置或获取用户名。
        /// </summary>
        string UserName { get; set; }
        #endregion

        #region Password
        /// <summary>
        /// 设置或获取登录搜索渠道的口令。
        /// </summary>
        string Password { get; set; }
        #endregion

        #region SignIn
        /// <summary>
        /// 执行登录。
        /// </summary>
        /// <returns>是否登录成功。</returns>
        bool SignIn();
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