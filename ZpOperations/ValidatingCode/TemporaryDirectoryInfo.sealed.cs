#region "TemporaryDirectoryInfo"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 10:01:34
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
 * 
 * ####     Type Name : TemporaryDirectoryInfo
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.TemporaryDirectoryInfo
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
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.TemporaryDirectoryInfo</para>
    /// <para>
    /// 验证码临时文件目录信息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class TemporaryDirectoryInfo
    {
        private string _path;
        static private TemporaryDirectoryInfo _directory;

        #region Path
        /// <summary>
        /// 获取临时文件目录路径。
        /// </summary>
        public string Path
        {
            get { return _path; }
            private set { _path = value; }
        }
        #endregion

        #region GetDirectoryFromConfig
        /// <summary>
        /// 从配置文件中获取临时文件目录信息。
        /// </summary>
        /// <returns><see cref="DirectoryInfo"/>对象实例。</returns>
        private DirectoryInfo GetDirectoryFromConfig()
        {
            string path = ZpConfigurationManager.GetConfig().ValidatingCodeTempDir.Path;
            if (string.IsNullOrWhiteSpace(path)) throw new NullReferenceException("未知的验证码临时文件存放目录路径！");
            return new DirectoryInfo(path);
        }
        #endregion

        #region InitPathProperty
        /// <summary>
        /// 初始化路径属性。
        /// </summary>
        private void InitPathProperty()
        {
            DirectoryInfo tempDir = this.GetDirectoryFromConfig();
            if (!tempDir.Exists) throw new DirectoryNotFoundException(string.Format("未找到验证码临时文件存放目录路径：“{0}”。", tempDir.FullName));
            this.Path = tempDir.FullName;
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="TemporaryDirectoryInfo" />对象实例。</para>
        /// </summary>
        private TemporaryDirectoryInfo()
        {
            this.InitPathProperty();
        }

        #endregion

        #region Directory
        /// <summary>
        /// 获取当前的<see cref="TemporaryDirectoryInfo"/>对象实例。
        /// </summary>
        static public TemporaryDirectoryInfo Directory
        {
            get
            {
                if (object.ReferenceEquals(_directory, null)) _directory = new TemporaryDirectoryInfo();
                return _directory;
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