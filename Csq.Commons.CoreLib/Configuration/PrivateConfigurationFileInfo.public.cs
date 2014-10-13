#region "PrivateConfigurationFileInfo"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-13 14:18:52
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Configuration
 * 
 * ####     Type Name : PrivateConfigurationFileInfo
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Configuration.PrivateConfigurationFileInfo
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
using System.Web.Hosting;

namespace MasterDuner.Cooperations.Csq.Commons.Configuration
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Configuration.PrivateConfigurationFileInfo</para>
    /// <para>
    /// 私有配置文件信息实体类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class PrivateConfigurationFileInfo
    {
        private string _name;
        private SearchChannels _channel;
        private string _fullName;

        #region Name
        /// <summary>
        /// 获取私有配置文件名称。
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        #endregion

        #region Channel
        /// <summary>
        /// 设置或获取搜索渠道。
        /// </summary>
        protected virtual SearchChannels Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        #endregion

        #region FullName
        /// <summary>
        /// 获取私有配置文件的完整名称。
        /// </summary>
        public virtual string FullName
        {
            get { return _fullName; }
            protected set { _fullName = value; }
        }
        #endregion

        #region GetChannelConfig
        /// <summary>
        /// 获取搜索渠道的配置。
        /// </summary>
        /// <param name="channel"><see cref="SearchChannels"/>中的一个值。</param>
        /// <returns><see cref="SearchChannelElement"/>对象实例。</returns>
        protected virtual SearchChannelElement GetChannelConfig(SearchChannels channel)
        {
            SearchChannelSection config = SearchChannelConfiguration.CurrentConfig.GetConfig();
            if (object.ReferenceEquals(config, null)) throw new NullReferenceException("无法获取搜索渠道配置！");
            SearchChannelElement channelConfig = config.Channels[(int)channel];
            if (object.ReferenceEquals(channelConfig, null)) throw new NullReferenceException(string.Format("无法获取搜索渠道{0}的配置！", channel));
            return channelConfig;
        }
        #endregion

        #region GetPrivateConfigFile
        /// <summary>
        /// 获取私有的配置文件信息。
        /// </summary>
        /// <param name="config"><see cref="SearchChannelElement"/>对象实例。</param>
        /// <returns><see cref="FileInfo"/>对象实例。</returns>
        protected virtual FileInfo GetPrivateConfigFile(SearchChannelElement config)
        {
            if (!config.EntryPoint.PrivateConfig.HasPrivateConfigurationFile) throw new NullReferenceException(string.Format("未找到搜索渠道{0}的私有配置文件！", config.ID));
            FileInfo fileInfo = new FileInfo(Path.Combine(HostingEnvironment.ApplicationPhysicalPath, config.EntryPoint.PrivateConfig.PrivateConfigurationFileName));
            if (!fileInfo.Exists) throw new FileNotFoundException(string.Format("未找到搜索渠道{0}的私有配置文件{1}！", config.ID, fileInfo.FullName));
            return fileInfo;
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="PrivateConfigurationFileInfo" />对象实例。</para>
        /// </summary>
        /// <param name="channel"><see cref="SearchChannels"/>中的一个值。</param>
        public PrivateConfigurationFileInfo(SearchChannels channel)
        {
            this.Channel = channel;
            SearchChannelElement config = this.GetChannelConfig(channel);
            FileInfo fileInfo = this.GetPrivateConfigFile(config);
            this.Name = fileInfo.Name;
            this.FullName = fileInfo.FullName;
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