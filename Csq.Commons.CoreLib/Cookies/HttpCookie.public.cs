#region "HttpCookie"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 10:55:49
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Cookies
 * 
 * ####     Type Name : HttpCookie
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Cookies.HttpCookie
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
using Cookie = System.Net.Cookie;

namespace MasterDuner.Cooperations.Csq.Commons.Cookies
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Cookies.HttpCookie</para>
    /// <para>
    /// Cookie对象实例。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class HttpCookie
    {
        private string _name;
        private string _value;
        private string _domain;

        #region Name
        /// <summary>
        /// 设置或获取Cookie名称。
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Value
        /// <summary>
        /// 设置或获取Cookie值。
        /// </summary>
        public virtual string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Domain
        /// <summary>
        /// 设置或获取Cookie所属的域名称。
        /// </summary>
        public virtual string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="HttpCookie" />对象实例。</para>
        /// </summary>
        public HttpCookie()
        {
        }

        #endregion

        #region ConvertFrom
        /// <summary>
        /// 将<paramref name="cookie"/>转换成<see cref="HttpCookie"/>对象实例。
        /// </summary>
        /// <param name="cookie"><see cref="Cookie"/>对象实例。</param>
        /// <returns><see cref="HttpCookie"/>对象实例。</returns>
        static public HttpCookie ConvertFrom(Cookie cookie)
        {
            return new HttpCookie() { Name = cookie.Name, Value = cookie.Value, Domain = cookie.Domain };
        }
        #endregion

        #region ConvertTo
        /// <summary>
        /// 将此<see cref="HttpCookie"/>对象实例转换成<see cref="Cookie"/>对象实例。
        /// </summary>
        /// <returns><see cref="Cookie"/>对象实例。</returns>
        public virtual Cookie ConvertTo()
        {
            return new Cookie(this.Name, this.Value, "/", this.Domain);
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