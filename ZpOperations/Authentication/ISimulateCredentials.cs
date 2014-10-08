#region "ISimulateCredentials"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 14:53:50
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Authentication
 * 
 * ####     Type Name : ISimulateCredentials
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Authentication.ISimulateCredentials
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

using System;

namespace MasterDuner.HHProjects.Csq.Highpincn.Authentication
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Authentication.ISimulateCredentials</para>
    /// <para>
    /// 模拟账户凭据接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ISimulateCredentials
    {
        #region UserName
        /// <summary>
        /// 设置或获取用户名。
        /// </summary>
        string UserName { get; set; }
        #endregion

        #region Password
        /// <summary>
        /// 设置或获取登录口令。
        /// </summary>
        string Password { get; set; }
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