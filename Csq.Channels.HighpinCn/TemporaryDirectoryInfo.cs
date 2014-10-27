#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-22 10:09:51
 * 
 * Machine Name : GLCHQWYCWINW7
 * 
 * Current User : GUOCOLAND/wangyucai
 * 
 * CLR Version : 4.0.30319.18444
 * 
 * Target Framework : This type is available for 4.0 and above versions of .NET Framework.
 */

#endregion

using System;
using System.IO;
using MasterDuner.Cooperations.Csq.Channels.Configuration;
using MasterDuner.Cooperations.Csq.Commons;
using MasterDuner.Cooperations.Csq.Commons.Configuration;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="TemporaryDirectoryInfo"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 提供了访问存放验证码图片临时目录信息的方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    internal sealed class TemporaryDirectoryInfo
    {
        private bool _exists;
        private string _path;
        static private TemporaryDirectoryInfo _this;

        #region Exists
        /// <summary>
        /// 获取临时目录是否存在。
        /// </summary>
        public bool Exists
        {
            get { return _exists; }
            private set { _exists = value; }
        }
        #endregion

        #region Path
        /// <summary>
        /// 获取临时目录路径。
        /// </summary>
        public string Path
        {
            get { return _path; }
            private set { _path = value; }
        }
        #endregion

        #region This
        /// <summary>
        /// 获取当前的临时目录。
        /// </summary>
        static public TemporaryDirectoryInfo This
        {
            get
            {
                if (object.ReferenceEquals(_this, null))
                    _this = new TemporaryDirectoryInfo();
                return _this;
            }
        }
        #endregion

        #region GetConfig
        /// <summary>
        /// 获取智联卓聘网私有配置。
        /// </summary>
        /// <returns><see cref="HPSection"/>对象实例。</returns>
        private HPSection GetConfig()
        {
            return new PrivateConfiguration(SearchChannels.HighpinCn).GetSection<HPSection>("www.highpin.cn");
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="TemporaryDirectoryInfo" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        private TemporaryDirectoryInfo()
        {
            HPSection config = this.GetConfig();
            if (string.IsNullOrWhiteSpace(config.ValidatingCodeImage.TemporaryDirectory))
                throw new NullReferenceException("未知的临时目录配置！");
            DirectoryInfo directory = new DirectoryInfo(config.ValidatingCodeImage.TemporaryDirectory);
            this.Exists = directory.Exists;
            if (!this.Exists)
                throw new DirectoryNotFoundException(string.Format("临时目录{0}不存在！", directory.Name));
            this.Path = directory.FullName;
        }

        #endregion
    }
}

#region Contact me

/*
 * E-mail Address : Masterduner@Yeah.net or Yucai.Wang-Public@Outlook.com
 * 
 * Mobile : +86 13621384677
 * 
 * QQ : 180261899
 */

#endregion

/* Copyright © 2014 Wang Yucai. All rights reserved. */