#region "HttpCookieCollection"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 11:11:25
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Cookies
 * 
 * ####     Type Name : HttpCookieCollection
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Cookies.HttpCookieCollection
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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Caching;

namespace MasterDuner.Cooperations.Csq.Commons.Cookies
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Cookies.HttpCookieCollection</para>
    /// <para>
    /// <see cref="HttpCookie"/>集合基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class HttpCookieCollection : List<HttpCookie>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="HttpCookieCollection" />对象实例。</para>
        /// </summary>
        public HttpCookieCollection()
        {
        }

        #endregion

        #region GetFromCache
        /// <summary>
        /// 从缓存中获取<see cref="HttpCookieCollection"/>对象实例。
        /// </summary>
        /// <param name="name">缓存名称。</param>
        /// <returns><see cref="HttpCookieCollection"/>对象实例。</returns>
        static public HttpCookieCollection GetFromCache(string name)
        {
            object data = HttpRuntime.Cache[name];
            return object.ReferenceEquals(data, null) ? null : data as HttpCookieCollection;
        }
        #endregion

        #region SaveInCache
        /// <summary>
        /// 保存到缓存中。
        /// </summary>
        public virtual void SaveInCache(string name)
        {
            HttpCookieCollection cache = HttpCookieCollection.GetFromCache(name);
            if (!object.ReferenceEquals(cache, null))
            {
                foreach (HttpCookie item in cache)
                {
                    if (!this.Contains(item.Name)) this.Add(item);
                }
                HttpRuntime.Cache[name] = this;
            }
            else
            {
                HttpRuntime.Cache.Insert(name, this, null, Cache.NoAbsoluteExpiration, new TimeSpan(0, 30, 0));
            }
        }
        #endregion

        #region Contains
        /// <summary>
        /// 验证集合中是否包含指定名称的<see cref="HttpCookie"/>对象实例。
        /// </summary>
        /// <param name="name">名称。</param>
        /// <returns>True or False。</returns>
        public virtual bool Contains(string name)
        {
            var enumerator = from item in this where item.Name.ToLower().Equals(name.ToLower()) select item;
            return !enumerator.Count<HttpCookie>().Equals(0);
        }
        #endregion

        #region ConvertFrom
        /// <summary>
        /// 将<paramref name="cookies"/>转换成<see cref="HttpCookieCollection"/>对象实例。
        /// </summary>
        /// <param name="cookies"><see cref="CookieCollection"/>对象实例。</param>
        /// <returns><see cref="HttpCookieCollection"/>对象实例。</returns>
        static public HttpCookieCollection ConvertFrom(CookieCollection cookies)
        {
            HttpCookieCollection collection = new HttpCookieCollection();
            foreach (Cookie item in cookies) collection.Add(HttpCookie.ConvertFrom(item));
            return collection;
        }
        #endregion

        #region CreateCookieContainer
        /// <summary>
        /// 将此<see cref="HttpCookieCollection"/>对象实例转换成<see cref="CookieContainer"/>对象实例。
        /// </summary>
        /// <returns><see cref="CookieContainer"/>对象实例。</returns>
        public virtual CookieContainer CreateCookieContainer()
        {
            CookieContainer container = new CookieContainer();
            foreach (HttpCookie item in this)
                container.Add(item.ConvertTo());
            return container;
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