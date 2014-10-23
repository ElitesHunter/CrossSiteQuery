#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 14:14:54
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

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="CookieCacheName"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于缓存智联卓聘网Cookie内容的标识名称。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class CookieCacheName
    {
        private Guid _bindSession;

        #region BindSession
        /// <summary>
        /// 设置绑定的会话ID。
        /// </summary>
        public Guid BindSession
        {
            private get { return _bindSession; }
            set { _bindSession = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="CookieCacheName" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public CookieCacheName()
        { }

        #endregion

        #region ToString
        /// <summary>
        /// 获取缓存标识名称。
        /// </summary>
        /// <returns><see cref="String"/></returns>
        override public string ToString()
        {
            return string.Format("ZLZP_COOKIES_SID_{0}", this.BindSession.ToString().Replace("-", string.Empty));
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