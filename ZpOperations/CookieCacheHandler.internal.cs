#region "CookieCacheHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 11:03:18
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : CookieCacheHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.CookieCacheHandler
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

using System.Collections.Generic;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.CookieCacheHandler</para>
    /// <para>
    /// 卓聘网Cookie数据会话级缓存处理。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    internal class CookieCacheHandler : SessionCacheHandler<IList<IZpCookie>>
    {
        private ClientSessionTag _sessionTag;
        private string _key;

        #region SessionTag
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        protected virtual ClientSessionTag SessionTag
        {
            get { return _sessionTag; }
            set { _sessionTag = value; }
        }
        #endregion

        #region Key
        /// <summary>
        /// 设置或获取缓存键名称。
        /// </summary>
        protected virtual string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="CookieCacheHandler" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        internal CookieCacheHandler(ClientSessionTag sessionTag)
        {
            this.SessionTag = sessionTag;
            this.Key = new SessionCacheKey(sessionTag).GetCacheKey(SessionCacheCategory.Cookies);
        }

        #endregion

        #region GetCookiesCache
        /// <summary>
        /// 获取Cookie缓存数据。
        /// </summary>
        /// <returns><see cref="IZpCookie"/>对象实例。</returns>
        internal virtual IList<IZpCookie> GetCookiesCache()
        {
            return this.GetCacheData(this.Key);
        }
        #endregion

        #region UpdateCookiesCache
        /// <summary>
        /// 更行Cookie缓存数据。
        /// </summary>
        /// <param name="cookies">Cookie数据。</param>
        internal virtual void UpdateCookiesCache(IList<IZpCookie> cookies)
        {
            IList<IZpCookie> hisCookies = this.GetCookiesCache();
            if (!object.ReferenceEquals(hisCookies, null))
            {
                bool isExist = false;
                foreach (IZpCookie hisItem in hisCookies)
                {
                    isExist = false;
                    foreach (IZpCookie item in cookies)
                    {
                        if (item.Name.Equals(hisItem.Name))
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist) cookies.Add(hisItem);
                }
            }
            this.UpdateCacheData(this.Key, cookies);
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