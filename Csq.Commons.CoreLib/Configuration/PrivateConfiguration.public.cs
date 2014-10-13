#region "PrivateConfiguration"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-13 14:49:32
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Configuration
 * 
 * ####     Type Name : PrivateConfiguration
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Configuration.PrivateConfiguration
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

using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Hosting;
using ConfigurationObject = System.Configuration.Configuration;

namespace MasterDuner.Cooperations.Csq.Commons.Configuration
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Configuration.PrivateConfiguration</para>
    /// <para>
    /// 管理搜索渠道私有配置。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class PrivateConfiguration
    {
        private SearchChannels _channel;
        private SearchChannelElement _channelConfig;
        private string _cacheID;

        #region ChannelConfig
        /// <summary>
        /// 设置或获取当前的渠道配置。
        /// </summary>
        protected virtual SearchChannelElement ChannelConfig
        {
            get { return _channelConfig; }
            set { _channelConfig = value; }
        }
        #endregion

        #region CacheID
        /// <summary>
        /// 设置或获取缓存标记名称。
        /// </summary>
        protected virtual string CacheID
        {
            get { return _cacheID; }
            set { _cacheID = value; }
        }
        #endregion

        #region Channel
        /// <summary>
        /// 设置或获取搜索渠道。
        /// </summary>
        public virtual SearchChannels Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="PrivateConfiguration" />对象实例。</para>
        /// </summary>
        public PrivateConfiguration()
            : this(SearchChannels.Unknown)
        {
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="PrivateConfiguration" />对象实例。</para>
        /// </summary>
        /// <param name="channel">搜索渠道。</param>
        public PrivateConfiguration(SearchChannels channel)
        {
            this.Channel = channel;
            this.ChannelConfig = SearchChannelConfiguration.CurrentConfig.GetConfig().Channels[(int)channel];
            this.CacheID = string.Format("MD_CSQ_CHANNEL{0}_PRIVATECFG", channel);
        }

        #endregion

        #region GetPrivateConfigFromCache
        /// <summary>
        /// 从缓存中获取私有配置。
        /// </summary>
        /// <param name="config">自定义配置对象。</param>
        /// <returns>缓存数据是否存在。</returns>
        protected virtual bool GetPrivateConfigFromCache(out ConfigurationObject config)
        {
            config = null;
            object data = HttpRuntime.Cache[this.CacheID];
            bool exist = !object.ReferenceEquals(data, null);
            if (exist) config = data as ConfigurationObject;
            return exist;
        }
        #endregion

        #region OpenPrivateConfiguration
        /// <summary>
        /// 打开私有配置文件，并获取相关配置。
        /// </summary>
        /// <returns><see cref="ConfigurationObject"/>对象实例。</returns>
        protected virtual ConfigurationObject OpenPrivateConfiguration()
        {
            PrivateConfigurationFileInfo fileInfo = new PrivateConfigurationFileInfo(this.Channel);
            VirtualDirectoryMapping vmapping = new VirtualDirectoryMapping(HostingEnvironment.ApplicationPhysicalPath, true, fileInfo.Name);
            WebConfigurationFileMap map = new WebConfigurationFileMap();
            map.VirtualDirectories.Add(string.Format("/{0}", (int)this.Channel), vmapping);
            ConfigurationObject config = WebConfigurationManager.OpenMappedWebConfiguration(map, string.Format("/{0}", (int)this.Channel), HostingEnvironment.SiteName);
            HttpRuntime.Cache.Insert(this.CacheID, config,
                new CacheDependency(
                    new string[2]{
                        fileInfo.FullName,
                        Path.Combine(HostingEnvironment.ApplicationPhysicalPath,"web.config")
                    }
                    ));
            return config;
        }
        #endregion

        #region GetSection
        /// <summary>
        /// 获取自定义配置节。
        /// </summary>
        /// <param name="sectionName">自定义配置节名称。</param>
        /// <typeparam name="T">自定义配置节对象类型。</typeparam>
        /// <returns><typeparamref name="T"/>类型配置对象实例。</returns>
        public virtual T GetSection<T>(string sectionName)
            where T : ConfigurationSection
        {
            ConfigurationObject config = null;
            if (!this.GetPrivateConfigFromCache(out config)) config = this.OpenPrivateConfiguration();
            return config.Sections[sectionName] as T;
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