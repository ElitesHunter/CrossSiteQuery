#region "ZpHttpRequestHandlerBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 15:02:39
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpHttpRequestHandlerBase
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpHttpRequestHandlerBase
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

using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpHttpRequestHandlerBase</para>
    /// <para>
    /// 卓聘网HTTP请求处理基类。
    /// </para>
    /// </summary>
    /// <typeparam name="TResult">HTTP响应数据结果。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public abstract class ZpHttpRequestHandlerBase<TResult> : IZpHttpRequestHandler<TResult>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHttpRequestHandlerBase" />对象实例。</para>
        /// </summary>
        protected ZpHttpRequestHandlerBase()
        {
        }

        #endregion

        #region RequestAndGetResponseData
        /// <summary>
        /// 启动一个请求，并获取响应数据。
        /// </summary>
        /// <param name="request">实现了<see cref="IZpHttpRequest"/>接口的对象实例。</param>
        /// <returns><typeparamref name="TResult"/>类型的响应数据。</returns>
        public virtual TResult RequestAndGetResponseData(IZpHttpRequest request)
        {
            IZpHttpResponse response = request.GetResponse();
            using (HttpWebResponse zpResponse = response.ResponseData)
            {
                this.SaveResponseCookiesCache((ClientSessionTag)response.SessionTag, zpResponse);
                return this.BuiltResult((ClientSessionTag)response.SessionTag, zpResponse);
            }
        }
        #endregion

        #region SaveResponseCookiesCache
        /// <summary>
        /// 保存Cookie到缓存中。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response"><see cref="HttpWebResponse"/>对象实例。</param>
        protected virtual void SaveResponseCookiesCache(ClientSessionTag sessionTag, HttpWebResponse response)
        {
            if (!object.ReferenceEquals(response.Cookies, null) && response.Cookies.Count > 0)
            {
                IList<IZpCookie> cookies = new List<IZpCookie>();
                foreach (Cookie item in response.Cookies)
                {
                    cookies.Add(new ZpCookie() { Name = item.Name, Value = item.Value });
                }
                new CookieCacheHandler(sessionTag).UpdateCookiesCache(cookies);
            }
        }
        #endregion

        #region BuiltResult
        /// <summary>
        /// 构建HTTP请求的相应结果。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response"><see cref="HttpWebResponse"/>对象实例。</param>
        /// <returns><typeparamref name="TResult"/>类型的结果。</returns>
        protected abstract TResult BuiltResult(ClientSessionTag sessionTag, HttpWebResponse response);
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