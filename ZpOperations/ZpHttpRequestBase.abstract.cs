#region "ZpHttpRequestBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:04:09
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpHttpRequestBase
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpHttpRequestBase
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

using System.Collections.Generic;
using System.Net;
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpHttpRequestBase</para>
    /// <para>
    /// 卓聘网HTTP请求基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public abstract class ZpHttpRequestBase : IZpHttpRequest
    {
        private ZpUri _url;
        private List<IZpCookie> _cookies;
        private ISessionTag _sessionTag;

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHttpRequestBase" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        protected ZpHttpRequestBase(ISessionTag sessionTag)
        {
            _cookies = new List<IZpCookie>();
            this.SessionTag = sessionTag;
            this.InitCookiesFromSessionCache();
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHttpRequestBase" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="urlName">URL在配置文件中的标识名称。</param>
        protected ZpHttpRequestBase(ISessionTag sessionTag, string urlName)
            : this(sessionTag)
        {
            this.Url = new ZpUri(urlName);
        }

        #endregion

        #region Url
        /// <summary>
        /// 设置或获取需要请求的卓聘网URL。
        /// </summary>
        public virtual IZpUri Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = (ZpUri)value;
            }
        }
        #endregion

        #region Cookies
        /// <summary>
        /// 获取来自卓聘网的Cookie数据。
        /// </summary>
        public virtual IList<IZpCookie> Cookies
        {
            get { return this._cookies; }
        }
        #endregion

        #region GetResponse
        /// <summary>
        /// 发送请求，并获取来自卓聘网的相应数据。
        /// </summary>
        /// <returns>实现了<see cref="IZpHttpResponse"/>接口的对象实例。</returns>
        public abstract IZpHttpResponse GetResponse();
        #endregion

        #region SessionTag
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        protected virtual ISessionTag SessionTag
        {
            get { return _sessionTag; }
            set { _sessionTag = value; }
        }
        #endregion

        #region InitCookiesFromSessionCache
        /// <summary>
        /// 从会话缓存中初始化卓聘网Cookie数据。
        /// </summary>
        protected virtual void InitCookiesFromSessionCache()
        {
            IList<IZpCookie> cookies = new CookieCacheHandler((ClientSessionTag)this.SessionTag).GetCookiesCache();
            if (!object.ReferenceEquals(cookies, null) && cookies.Count > 0)
            {
                foreach (IZpCookie item in cookies)
                    this.Cookies.Add(item);
            }
        }
        #endregion

        #region RequestHighpinCn
        /// <summary>
        /// 向卓聘网发送一个请求。
        /// </summary>
        /// <returns><see cref="HttpWebRequest"/>对象实例。</returns>
        protected virtual HttpWebRequest RequestHighpinCn()
        {
            return (HttpWebRequest)HttpWebRequest.Create(this.Url.Url);
        }
        #endregion

        #region SetHttpRequestMethod
        /// <summary>
        /// 设置HTTP请求的Method变量值。
        /// </summary>
        protected virtual void SetHttpRequestMethod(HttpWebRequest request)
        {
            request.Method = this.Method.ToString().ToUpper();
        }
        #endregion

        #region Method
        private HttpMethods _httpMethod = HttpMethods.Post;
        /// <summary>
        /// 设置或获取HTTP请求Method变量。
        /// </summary>
        public virtual HttpMethods Method
        {
            get
            {
                return this._httpMethod;
            }
            set
            {
                this._httpMethod = value;
            }
        }
        #endregion

        #region GetCookieContainer
        /// <summary>
        /// 获取HTTP请求所需的<see cref="CookieContainer"/>对象实例。
        /// </summary>
        /// <returns><see cref="CookieContainer"/>对象实例。</returns>
        protected virtual CookieContainer GetCookieContainer()
        {
            CookieContainer cookies = new CookieContainer();
            foreach (IZpCookie item in this.Cookies)
            {
                cookies.Add(new Cookie(item.Name, item.Value, "/", ZpConfigurationManager.GetConfig().Resources.DomainName));
            }
            return cookies;
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