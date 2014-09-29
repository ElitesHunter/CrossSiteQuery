#region "SessionCacheHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:49:40
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : SessionCacheHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.SessionCacheHandler
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
using System.IO;
using System.Web;
using System.Web.Caching;
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.SessionCacheHandler</para>
    /// <para>
    /// 处理会话级缓存数据。
    /// </para>
    /// </summary>
    /// <typeparam name="T">缓存数据类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    internal class SessionCacheHandler<T> : ISessionCache<T>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SessionCacheHandler" />对象实例。</para>
        /// </summary>
        internal SessionCacheHandler()
        {
        }

        #endregion

        #region GetCacheData
        /// <summary>
        /// 获取缓存数据。
        /// </summary>
        /// <param name="key">键名称。</param>
        /// <returns><typeparamref name="T"/>类型的缓存数据。</returns>
        public virtual T GetCacheData(string key)
        {
            object data = HttpRuntime.Cache[key];
            return object.ReferenceEquals(data, null) ? default(T) : (T)data;
        }
        #endregion

        #region UpdateCacheData
        /// <summary>
        /// 更新缓存数据。
        /// </summary>
        /// <param name="key">键名称。</param>
        /// <param name="data"><typeparamref name="T"/>类型的缓存数据。</param>
        public virtual void UpdateCacheData(string key, T data)
        {
            T _data = this.GetCacheData(key);
            if (object.ReferenceEquals(_data, null) || object.ReferenceEquals(_data, default(T)))
            {
                SessionCachingElement cacheConfig = ZpConfigurationManager.GetConfig().SessionCaching;
                HttpRuntime.Cache.Insert(key, data,
                    new CacheDependency(Path.Combine(HttpRuntime.AppDomainAppPath, "web.config")),
                    !cacheConfig.CacheSlidingExpirationEnabled ? DateTime.Now.AddMinutes(cacheConfig.AbsoluteExpirationMinutes) : Cache.NoAbsoluteExpiration,
                    cacheConfig.CacheSlidingExpirationEnabled ? new TimeSpan(0, cacheConfig.SlidingExpirationMinutes, 0) : Cache.NoSlidingExpiration
                    );
            }
            else
            {
                HttpRuntime.Cache[key] = data;
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