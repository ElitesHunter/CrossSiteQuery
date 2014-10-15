#region "SearchChannelCredentials"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 9:48:35
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : SearchChannelCredentials
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.SearchChannelCredentials
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
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.SearchChannelCredentials</para>
    /// <para>
    /// 搜索渠道身份认证凭据基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class SearchChannelCredentials
    {
        private string _userName;
        private string _password;

        #region UserName
        /// <summary>
        /// 设置或获取用户登录名。
        /// </summary>
        [DataMember]
        public virtual string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        #endregion

        #region Password
        /// <summary>
        /// 设置或获取登录口令。
        /// </summary>
        [DataMember]
        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SearchChannelCredentials" />对象实例。</para>
        /// </summary>
        public SearchChannelCredentials()
        {
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