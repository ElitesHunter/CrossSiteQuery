#region "StaticUserCredentials"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 14:56:58
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Authentication
 * 
 * ####     Type Name : StaticUserCredentials
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Authentication.StaticUserCredentials
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

using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn.Authentication
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Authentication.StaticUserCredentials</para>
    /// <para>
    /// 静态用户账户凭据。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class StaticUserCredentials : ISimulateCredentials
    {
        static private StaticUserCredentials _current;

        #region Current
        /// <summary>
        /// 获取当前的静态用户凭据。
        /// </summary>
        static public StaticUserCredentials Current
        {
            get
            {
                AnalogousCredentialsElement config = ZpConfigurationManager.GetConfig().Authentication.AnalogousAccount;
                if (object.ReferenceEquals(_current, null)) _current = new StaticUserCredentials() { UserName = config.UserName, Password = config.Passphrase };
                return _current;
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="StaticUserCredentials" />对象实例。</para>
        /// </summary>
        private StaticUserCredentials()
        {
        }

        #endregion

        #region UserName
        private string _userName;
        /// <summary>
        /// 设置或获取账户名。
        /// </summary>
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        #endregion

        #region Password
        private string _password;
        /// <summary>
        /// 设置或获取登录口令。
        /// </summary>
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
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