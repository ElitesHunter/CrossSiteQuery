#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-29 15:06:55
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
using MasterDuner.Cooperations.Csq.Channels.Configuration;
using MasterDuner.Cooperations.Csq.Commons;
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons.Configuration;
using MasterDuner.Cooperations.Csq.Channels.Generators;
using System.Text;
using System.Net;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ResumeSearchRequestMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于请求简历搜索数据的消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    internal sealed class ResumeSearchRequestMessage : HttpWebRequestMessage
    {
        private CookieCacheName _cookieCacheName;
        private HPSection _config;
        private HPRequirement _searchParameter;
        private ResultPage _paging;

        #region SearchParameter
        /// <summary>
        /// 设置或获取智联卓聘网搜索参数。
        /// </summary>
        internal HPRequirement SearchParameter
        {
            get { return _searchParameter; }
            set { _searchParameter = value; }
        }
        #endregion

        #region Paging
        /// <summary>
        /// 设置或获取分页信息。
        /// </summary>
        internal ResultPage Paging
        {
            get { return _paging; }
            set { _paging = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResumeSearchRequestMessage" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal ResumeSearchRequestMessage(Guid sessionID)
            : base(sessionID)
        {
            this._cookieCacheName = new CookieCacheName() { BindSession = sessionID };
            this._config = new PrivateConfiguration().GetSection<HPSection>("www.highpin.cn");
        }

        #endregion

        #region CacheID
        /// <summary>
        /// 获取缓存数据标识名称。
        /// </summary>
        protected override string CacheID
        {
            get
            {
                return this._cookieCacheName.ToString();
            }
        }
        #endregion

        #region Url
        /// <summary>
        /// 获取请求的基本URL。
        /// </summary>
        protected override string Url
        {
            get
            {
                return this._config.ActionUrls["SearchResume"].BaseUrl;
            }
        }
        #endregion

        #region CreateRequestData
        /// <summary>
        /// 创建需要发送到智联卓聘网的请求数据。
        /// </summary>
        /// <returns>字节数据。</returns>
        private byte[] CreateRequestData()
        {
            string s = new SearchRequirementUrlGenerator() { SearchParameter = this.SearchParameter, Page = this.Paging }.TransformText();
            return Encoding.UTF8.GetBytes(s);
        }
        #endregion

        #region CreateHttpRequest
        /// <summary>
        /// 创建HTTP请求对象实例。
        /// </summary>
        /// <returns><see cref="HttpWebRequest"/>对象实例。</returns>
        protected override HttpWebRequest CreateHttpRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Url);
            byte[] data = this.CreateRequestData();
            request.AllowAutoRedirect = true;
            request.ContentLength = data.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = this.CreateCookieContainer();
            request.Method = this.GetCommunicationMethodStr();
            request.GetRequestStream().Write(data, 0, data.Length);
            return request;
        }
        #endregion

        #region SendAndGet
        /// <summary>
        /// 发送请求并获取搜索结果。
        /// </summary>
        /// <typeparam name="TMessage"><see cref="ResumeSearchResponseMessage"/>类型。</typeparam>
        /// <returns><see cref="ResumeSearchResponseMessage"/>类型的对象实例。</returns>
        public override TMessage SendAndGet<TMessage>()
        {
            HttpWebRequest request = this.CreateHttpRequest();
            ResumeSearchResponseMessage message = new ResumeSearchResponseMessage(this.BindSessionID, request.GetResponse() as HttpWebResponse);
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