#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-11-18 10:25:15
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
using System.Web;
using MasterDuner.Cooperations.Csq.Commons;
using MasterDuner.Cooperations.Csq.Commons.Communications;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ResumeDetailsRequestMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于请求简历详情的消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [Serializable]
    [SearchChannel(SearchChannels.HighpinCn)]
    internal sealed class ResumeDetailsRequestMessage : HttpWebRequestMessage
    {
        private CookieCacheName _cookieCacheName;
        private string _url;

        #region CookieCacheName
        /// <summary>
        /// 设置或获取Cookie缓存的标记名称。
        /// </summary>
        private CookieCacheName CookieCacheName
        {
            get { return _cookieCacheName; }
            set { _cookieCacheName = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResumeDetailsRequestMessage" />对象实例。
        /// </summary>
        /// <param name="sessionID">会话标识。</param>
        /// <param name="detailUrl">简历详情URL地址。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public ResumeDetailsRequestMessage(Guid sessionID, string detailUrl)
            : base(sessionID)
        {
            this.CookieCacheName = new CookieCacheName() { BindSession = sessionID };
            this._url = this.UrlDecode(string.Format("http://h.highpin.cn{0}", detailUrl));
            this.Method = CommunicationMethods.HttpGet;
        }

        #endregion

        #region CacheID
        /// <summary>
        /// 获取缓存标记。
        /// </summary>
        protected override string CacheID
        {
            get
            {
                return this._cookieCacheName.ToString();
            }
        }
        #endregion

        #region UrlDecode
        /// <summary>
        /// 对URL进行解码。
        /// </summary>
        /// <param name="url">URL。</param>
        /// <returns>解码后的URL表达式。</returns>
        private string UrlDecode(string url)
        {
            return HttpUtility.UrlDecode(url).Replace("&amp;", "&").Replace("&lt;", "<").Replace("&gt;", ">");
        }
        #endregion

        #region CreateHttpRequest
        /// <summary>
        /// 创建<see cref="HttpWebRequest"/>对象实例。
        /// </summary>
        /// <returns><see cref="HttpWebRequest"/>对象实例。</returns>
        protected override HttpWebRequest CreateHttpRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this._url);
            request.AllowAutoRedirect = true;
            request.CookieContainer = this.CreateCookieContainer();
            request.Method = this.GetCommunicationMethodStr();
            return request;
        }
        #endregion

        #region SendAndGet
        /// <summary>
        /// 发送请求并获取响应消息。
        /// </summary>
        /// <typeparam name="TMessage">响应消息类型。</typeparam>
        /// <returns><typeparamref name="TMessage"/>类型的响应消息。</returns>
        public override TMessage SendAndGet<TMessage>()
        {
            ResumeDetailsResponseMessage message = new ResumeDetailsResponseMessage(
                base.BindSessionID,
                this.CreateHttpRequest().GetResponse() as HttpWebResponse);
            message.Init();
            return message as TMessage;
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