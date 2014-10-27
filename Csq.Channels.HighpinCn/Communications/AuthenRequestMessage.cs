#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 14:59:43
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
using System.Text;
using MasterDuner.Cooperations.Csq.Channels.Configuration;
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons.Configuration;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="AuthenRequestMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 身份认证请求消息类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    internal sealed class AuthenRequestMessage : HttpWebRequestMessage
    {
        private CookieCacheName _cookieCacheName;
        private HPCredentials _credentials;
        private HPSection _config;

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

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="AuthenRequestMessage" />对象实例。
        /// </summary>
        /// <param name="sessionID">会话标识。</param>
        /// <param name="credentials">身份认证凭据。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal AuthenRequestMessage(Guid sessionID, HPCredentials credentials)
            : base(sessionID)
        {
            this._cookieCacheName = new CookieCacheName() { BindSession = sessionID };
            this._credentials = credentials;
            this._config = new PrivateConfiguration(Commons.SearchChannels.HighpinCn).GetSection<HPSection>("www.highpin.cn");
            this.Method = CommunicationMethods.HttpPost;
        }

        #endregion

        #region GetValidatingCode
        /// <summary>
        /// 获取智联卓聘网的验证码。
        /// </summary>
        /// <returns>验证码。</returns>
        private string GetValidatingCode()
        {
            return new ValidatingCodeMessageProcessor(this.BindSessionID).SendAndGet().ValidatingCode;
        }
        #endregion

        #region Url
        /// <summary>
        /// 获取发送请求的URL。
        /// </summary>
        protected override string Url
        {
            get
            {
                return this._config.ActionUrls["SignInPage"].BaseUrl;
            }
        }
        #endregion

        #region CreatePostData
        /// <summary>
        /// 创建需要执行HTTP Post的数据。
        /// </summary>
        /// <returns>字节数据。</returns>
        private byte[] CreatePostData()
        {
            string dataStr = string.Format("username={0}&password={1}&postcode={2}&rememberme=false&userType=2",
                this._credentials.UserName,
                this._credentials.Password,
                this.GetValidatingCode());
            return Encoding.UTF8.GetBytes(dataStr);
        }
        #endregion

        #region CreateHttpRequest
        /// <summary>
        /// 创建一个<see cref="HttpWebRequest"/>对象实例。
        /// </summary>
        /// <returns><see cref="HttpWebRequest"/>对象实例。</returns>
        protected override HttpWebRequest CreateHttpRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Url);
            request.AllowAutoRedirect = true;
            byte[] data = this.CreatePostData();
            request.ContentLength = data.Length;
            request.ContentType = @"application/x-www-form-urlencoded; charset=UTF-8";
            request.CookieContainer = base.CreateCookieContainer();
            request.Method = base.GetCommunicationMethodStr();
            request.GetRequestStream().Write(data, 0, data.Length);
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
            HttpWebRequest request = this.CreateHttpRequest();
            AuthenResponseMessage response = new AuthenResponseMessage(request.GetResponse() as HttpWebResponse, this.BindSessionID);
            response.Init();
            return response as TMessage;
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