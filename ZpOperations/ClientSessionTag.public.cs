#region "ClientSessionTag"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 14:18:11
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ClientSessionTag
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ClientSessionTag
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

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ClientSessionTag</para>
    /// <para>
    /// 提供给客户端的会话标记。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class ClientSessionTag : ISessionTag
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ClientSessionTag" />对象实例。</para>
        /// </summary>
        public ClientSessionTag()
        {
        }

        #endregion

        #region SessionId
        private Guid _sessionId;
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        public virtual Guid SessionId
        {
            get
            {
                return this._sessionId;
            }
            set
            {
                this._sessionId = value;
            }
        }
        #endregion

        #region CreateSessionTag
        /// <summary>
        /// 创建一个会话标记。
        /// </summary>
        /// <returns><see cref="ClientSessionTag"/>对象实例。</returns>
        static public ClientSessionTag CreateSessionTag()
        {
            return new ClientSessionTag() { SessionId = Guid.NewGuid() };
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