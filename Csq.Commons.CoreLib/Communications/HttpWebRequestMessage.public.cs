#region "HttpWebRequestMessage"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-16 9:47:28
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Communications
 * 
 * ####     Type Name : HttpWebRequestMessage
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Communications.HttpWebRequestMessage
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
using System.Net;
using MasterDuner.Cooperations.Csq.Commons.Cookies;

namespace MasterDuner.Cooperations.Csq.Commons.Communications
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Communications.HttpWebRequestMessage</para>
    /// <para>
    /// HTTP请求消息基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class HttpWebRequestMessage : CommunicationMessage
    {
        #region Url
        /// <summary>
        /// 获取请求的URL地址。
        /// </summary>
        protected virtual string Url
        {
            get { return string.Empty; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="HttpWebRequestMessage" />对象实例。</para>
        /// </summary>
        public HttpWebRequestMessage(Guid sessionID)
            : base(sessionID)
        {
        }

        #endregion

        #region CreateCookieContainer
        /// <summary>
        /// 创建<see cref="CookieContainer"/>对象实例。
        /// </summary>
        /// <returns><see cref="CookieContainer"/>对象实例。</returns>
        protected virtual CookieContainer CreateCookieContainer()
        {
            return HttpCookieCollection.GetFromCache(this.CacheID).CreateCookieContainer();
        }
        #endregion

        #region CreateHttpRequest
        /// <summary>
        /// 创建HTTP请求对象实例。
        /// </summary>
        /// <returns><see cref="HttpWebRequest"/>对象实例。</returns>
        protected virtual HttpWebRequest CreateHttpRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(this.Url));
            request.ContentType = this.ContentType;
            request.ContentLength = this.ContentLength;
            request.CookieContainer = this.CreateCookieContainer();
            request.AllowAutoRedirect = true;
            request.KeepAlive = true;
            request.Method = this.GetCommunicationMethodStr();
            return request;
        }
        #endregion

        #region GetResponse
        /// <summary>
        /// 获取HTTP相应消息。
        /// </summary>
        /// <typeparam name="TResponse">HTTP响应消息类型。</typeparam>
        /// <returns><typeparamref name="TResponse"/>类型的响应消息。</returns>
        protected virtual TResponse GetResponse<TResponse>()
            where TResponse : HttpWebResponseMessage
        {
            HttpWebRequest request = this.CreateHttpRequest();
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            return new HttpWebResponseMessage(this.BindSessionID, response) as TResponse;
        }
        #endregion

        #region SendAndGet
        /// <summary>
        /// 发送请求并获取响应消息。
        /// </summary>
        /// <typeparam name="TMessage">相应消息类型。</typeparam>
        /// <returns><typeparamref name="TMessage"/>类型的相应消息。</returns>
        public override TMessage SendAndGet<TMessage>()
        {
            return this.GetResponse<HttpWebResponseMessage>() as TMessage;
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