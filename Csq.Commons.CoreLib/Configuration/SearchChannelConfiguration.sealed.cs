#region "SearchChannelConfiguration"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-13 13:57:23
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Configuration
 * 
 * ####     Type Name : SearchChannelConfiguration
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Configuration.SearchChannelConfiguration
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
using System.Web.Configuration;
using System.Web.Hosting;

namespace MasterDuner.Cooperations.Csq.Commons.Configuration
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Configuration.SearchChannelConfiguration</para>
    /// <para>
    /// 管理搜索渠道配置。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class SearchChannelConfiguration
    {
        private static readonly string WebConfigurationFilePath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "web.config");
        private const string CacheID = "MD_CSQ_COMMONS_CONFIG";
        private const string SectionName = "csq.channels";
        static private SearchChannelConfiguration _currentConfig;

        #region GetConfigFromCache
        /// <summary>
        /// 从缓存区中获取搜索渠道配置。
        /// </summary>
        /// <param name="config">搜索渠道配置对象。</param>
        /// <returns>缓存中是否包含搜索渠道配置。</returns>
        private bool GetConfigFromCache(out SearchChannelSection config)
        {
            config = null;
            object data = HttpRuntime.Cache[SearchChannelConfiguration.CacheID];
            bool existCache = !object.ReferenceEquals(data, null);
            if (existCache) config = data as SearchChannelSection;
            return existCache;
        }
        #endregion

        #region OpenWebConfiguration
        /// <summary>
        /// 直接读取WEB配置文件，并从中获取搜索渠道配置。
        /// </summary>
        /// <returns><see cref="SearchChannelSection"/>对象实例。</returns>
        private SearchChannelSection OpenWebConfiguration()
        {
            SearchChannelSection config = WebConfigurationManager.GetSection(SearchChannelConfiguration.SectionName) as SearchChannelSection;
            HttpRuntime.Cache.Insert(SearchChannelConfiguration.CacheID, config,
                new CacheDependency(SearchChannelConfiguration.WebConfigurationFilePath),
                DateTime.Now.AddDays(1), Cache.NoSlidingExpiration);
            return config;
        }
        #endregion

        #region GetConfig
        /// <summary>
        /// 获取搜索渠道配置。
        /// </summary>
        /// <returns><see cref="SearchChannelSection"/>对象实例。</returns>
        public SearchChannelSection GetConfig()
        {
            SearchChannelSection config;
            if (!this.GetConfigFromCache(out config)) config = this.OpenWebConfiguration();
            return config;
        }
        #endregion

        #region CurrentConfig
        /// <summary>
        /// 获取当前的配置。
        /// </summary>
        static public SearchChannelConfiguration CurrentConfig
        {
            get
            {
                if (object.ReferenceEquals(_currentConfig, null)) _currentConfig = new SearchChannelConfiguration();
                return _currentConfig;
            }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SearchChannelConfiguration" />对象实例。</para>
        /// </summary>
        public SearchChannelConfiguration()
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