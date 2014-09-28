#region "ZpConfigurationManager"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 11:41:36
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Configuration
 * 
 * ####     Type Name : ZpConfigurationManager
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Configuration.ZpConfigurationManager
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
using ConfigObject = System.Configuration.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn.Configuration
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Configuration.ZpConfigurationManager</para>
    /// <para>
    /// 卓聘网配置对象管理器。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class ZpConfigurationManager
    {
        private const string CacheKey = "CSQ_ZP_CONFIG";
        private const string ConfigFileName = "highpin.cn.config";

        #region HasConfigurationObjectCaching
        /// <summary>
        /// 验证是否包含了配置对象的缓存。
        /// </summary>
        /// <returns>true 、false。</returns>
        static private bool HasConfigurationObjectCaching()
        {
            return !object.ReferenceEquals(HttpRuntime.Cache[ZpConfigurationManager.CacheKey], null);
        }
        #endregion

        #region GetConfig
        /// <summary>
        /// 获取配置。
        /// </summary>
        /// <returns><see cref="HighpinCnQueryServiceSection"/>配置对象实例。</returns>
        static public HighpinCnQueryServiceSection GetConfig()
        {
            if (ZpConfigurationManager.HasConfigurationObjectCaching())
            {
                return HttpRuntime.Cache[ZpConfigurationManager.CacheKey] as HighpinCnQueryServiceSection;
            }
            else
            {
                return ZpConfigurationManager.OpenConfigFile();
            }
        }
        #endregion

        #region GetConfigFile
        /// <summary>
        /// 获取配置文件信息。
        /// </summary>
        /// <returns><see cref="FileInfo"/>对象实例。</returns>
        static private FileInfo GetConfigFile()
        {
            return new FileInfo(Path.Combine(HttpRuntime.AppDomainAppPath, ZpConfigurationManager.ConfigFileName));
        }
        #endregion

        #region OpenConfigFile
        /// <summary>
        /// 打开配置文件。
        /// </summary>
        /// <returns><see cref="HighpinCnQueryServiceSection"/>对象实例。</returns>
        /// <exception cref="FileNotFoundException">当未找到配置文件时，抛出此异常。</exception>
        static private HighpinCnQueryServiceSection OpenConfigFile()
        {
            FileInfo configFile = ZpConfigurationManager.GetConfigFile();
            if (!configFile.Exists) throw new FileNotFoundException("未找到配置文件!", configFile.FullName);
            VirtualDirectoryMapping virtualDirectory = new VirtualDirectoryMapping(HttpRuntime.AppDomainAppPath, false, ConfigFileName);
            WebConfigurationFileMap configFileMap = new WebConfigurationFileMap();
            configFileMap.VirtualDirectories.Add("HighpinConfig", virtualDirectory);
            ConfigObject obj = WebConfigurationManager.OpenMappedWebConfiguration(configFileMap, "HighpinConfig", HostingEnvironment.SiteName);
            HighpinCnQueryServiceSection config = obj.Sections["csq.highpin.cn"] as HighpinCnQueryServiceSection;
            ZpConfigurationManager.SaveIntoCache(config, configFile.FullName);
            return config;
        }
        #endregion

        #region SaveIntoCache
        /// <summary>
        /// 保存到缓存区中。
        /// </summary>
        /// <param name="config"><see cref="HighpinCnQueryServiceSection"/>对象实例。</param>
        /// <param name="dependency">缓存依赖配置文件名称。</param>
        static private void SaveIntoCache(HighpinCnQueryServiceSection config, string dependency)
        {
            HttpRuntime.Cache.Insert(CacheKey, config,
                    new CacheDependency(new string[2] { dependency, Path.Combine(HttpRuntime.AppDomainAppPath, "web.config") }),
                    DateTime.Now.AddDays(1),
                    Cache.NoSlidingExpiration
                );
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