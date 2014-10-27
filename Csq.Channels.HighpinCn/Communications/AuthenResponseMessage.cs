#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 14:28:46
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
using System.Net;
using MasterDuner.Cooperations.Csq.Channels.RegExpressions;
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="AuthenResponseMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于处理智联卓聘网身份认证HTTP响应消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    public sealed class AuthenResponseMessage : HttpWebResponseMessage
    {
        private CookieCacheName _cookieCacheName;
        private int _status;

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="AuthenResponseMessage" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public AuthenResponseMessage(HttpWebResponse response, Guid sessionID)
            : base(sessionID, response)
        {
            this._cookieCacheName = new CookieCacheName() { BindSession = sessionID };
        }

        #endregion

        #region CacheID
        /// <summary>
        /// 获取缓存标记名称。
        /// </summary>
        protected override string CacheID
        {
            get
            {
                return this._cookieCacheName.ToString();
            }
        }
        #endregion

        #region Status
        /// <summary>
        /// 获取身份认证状态值。
        /// </summary>
        internal int Status
        {
            get { return _status; }
            private set { _status = value; }
        }
        #endregion

        #region GetResponseText
        /// <summary>
        /// 获取响应文本内容。
        /// </summary>
        /// <returns><see cref="String"/></returns>
        private string GetResponseText()
        {
            string s = string.Empty;
            using (StreamReader reader = new StreamReader(base.Response.GetResponseStream()))
            {
                try
                {
                    s = reader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            return s;
        }
        #endregion

        #region TextResponseText
        /// <summary>
        /// 验证HTTP响应文本。
        /// </summary>
        /// <param name="s">需要检验的文本内容。</param>
        /// <returns>是否合法。</returns>
        private bool TextResponseText(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && new HPAuthenResponseTextExpression().IsMatch(s);
        }
        #endregion

        #region Init
        /// <summary>
        /// 初始化消息。
        /// </summary>
        public override void Init()
        {
            base.Init();
            string s = this.GetResponseText();
            if (this.TextResponseText(s))
                this.Status = int.Parse(s);
            else
                this.Status = -1;
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