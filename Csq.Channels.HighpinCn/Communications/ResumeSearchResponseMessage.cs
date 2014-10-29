#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-29 15:00:49
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
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ResumeSearchResponseMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 简历搜索结果响应消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    internal sealed class ResumeSearchResponseMessage : HttpWebResponseMessage
    {
        private string _html;
        private CookieCacheName _cookieCacheName;

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResumeSearchResponseMessage" />对象实例。
        /// </summary>
        /// <param name="sessionID">搜索服务会话标记。</param>
        /// <param name="response">搜索结果响应。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public ResumeSearchResponseMessage(Guid sessionID, HttpWebResponse response)
            : base(sessionID, response)
        {
            this._cookieCacheName = new CookieCacheName() { BindSession = sessionID };
        }

        #endregion

        #region CacheID
        /// <summary>
        /// 获取缓存数据标记名称。
        /// </summary>
        protected override string CacheID
        {
            get
            {
                return this._cookieCacheName.ToString();
            }
        }
        #endregion

        #region HTML
        /// <summary>
        /// 设置或获取HTML型的搜索结果。
        /// </summary>
        internal string HTML
        {
            get { return _html; }
            set { _html = value; }
        }
        #endregion

        #region Init
        /// <summary>
        /// 初始化此消息。
        /// </summary>
        public override void Init()
        {
            base.Init();
            using (Stream responseStream = this.Response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    try
                    {
                        this.HTML = reader.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        reader.Close();
                        responseStream.Close();
                    }
                }
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