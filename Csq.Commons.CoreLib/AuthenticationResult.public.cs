#region "AuthenticationResult"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 9:54:22
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : AuthenticationResult
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.AuthenticationResult
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.AuthenticationResult</para>
    /// <para>
    /// 搜索渠道身份认证结果。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class AuthenticationResult
    {
        private bool _isSuccessful;
        private PerformStatus _status;
        private Guid _bindSessionID;

        #region IsSuccessful
        /// <summary>
        /// 设置或获取身份认证是否成功。
        /// </summary>
        [DataMember]
        public virtual bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        #endregion

        #region Status
        /// <summary>
        /// 设置或获取身份认证执行状态。
        /// </summary>
        [DataMember]
        public virtual PerformStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region BindSessionID
        /// <summary>
        /// 设置或获取客户端与搜索服务绑定的会话标识。
        /// </summary>
        [DataMember]
        public virtual Guid BindSessionID
        {
            get { return _bindSessionID; }
            set { _bindSessionID = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="AuthenticationResult" />对象实例。</para>
        /// </summary>
        public AuthenticationResult()
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