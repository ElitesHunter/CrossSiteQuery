#region "SessionCacheKey"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:41:01
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : SessionCacheKey
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.SessionCacheKey
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.SessionCacheKey</para>
    /// <para>
    /// 会话级缓存键名称对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    internal class SessionCacheKey : ISessionCacheKey
    {
        private ClientSessionTag _sessionTag;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SessionCacheKey" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag"><see cref="ClientSessionTag"/>对象实例。</param>
        internal SessionCacheKey(ClientSessionTag sessionTag)
        {
            this._sessionTag = sessionTag;
        }

        #endregion

        #region SessionTag
        /// <summary>
        /// 获取会话标记。
        /// </summary>
        public virtual ISessionTag SessionTag
        {
            get { return this._sessionTag; }
        }
        #endregion

        #region GetCacheKey
        /// <summary>
        /// 获取缓存数据键名称。
        /// </summary>
        /// <param name="category"><see cref="SessionCacheCategory"/>中的一个值。</param>
        /// <returns>缓存键名称。</returns>
        public virtual string GetCacheKey(SessionCacheCategory category)
        {
            return string.Format("{0}_{1}", this.SessionTag.SessionId.ToString().Replace("-", string.Empty), category.ToString().ToUpper());
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