#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-22 9:44:13
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
using System.Net;
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ValidatingCodeResponseMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 智联卓聘网验证码响应消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    internal sealed class ValidatingCodeResponseMessage : HttpWebResponseMessage
    {
        private string _validatingCode;
        private CookieCacheName _cookieCacheName;

        #region ValidatingCode
        /// <summary>
        /// 获取验证码。
        /// </summary>
        internal string ValidatingCode
        {
            get { return _validatingCode; }
            private set { _validatingCode = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ValidatingCodeResponseMessage" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal ValidatingCodeResponseMessage(HttpWebResponse response, Guid sessionID)
            : base(sessionID, response)
        {
            this._cookieCacheName = new CookieCacheName() { BindSession = sessionID };
        }

        #endregion

        #region Init
        /// <summary>
        /// 初始化验证码响应消息。
        /// </summary>
        public override void Init()
        {
            base.Init();
            this.ValidatingCode = new ValidatingCodeImageProcessor(this.Response.GetResponseStream()).GetValidatingCode();
        }
        #endregion

        #region CacheID
        /// <summary>
        /// 获取缓存标识名称。
        /// </summary>
        protected override string CacheID
        {
            get
            {
                return this._cookieCacheName.ToString();
            }
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