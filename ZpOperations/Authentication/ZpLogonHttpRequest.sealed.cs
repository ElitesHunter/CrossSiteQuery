#region "ZpLogonHttpRequest"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 15:03:56
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Authentication
 * 
 * ####     Type Name : ZpLogonHttpRequest
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Authentication.ZpLogonHttpRequest
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

using System.Net;
using System.Text;
using System;

namespace MasterDuner.HHProjects.Csq.Highpincn.Authentication
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Authentication.ZpLogonHttpRequest</para>
    /// <para>
    /// 卓聘网登录HTTP请求。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ZpLogonHttpRequest : ZpHttpRequestBase
    {
        private string _userName;
        private string _password;
        private string _validatingCode;

        #region UserName
        /// <summary>
        /// 设置或获取用户名。
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        #endregion

        #region Password
        /// <summary>
        /// 设置或获取口令。
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion

        #region ValidatingCode
        /// <summary>
        /// 设置或获取验证码。
        /// </summary>
        public string ValidatingCode
        {
            get { return _validatingCode; }
            set { _validatingCode = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpLogonHttpRequest" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        public ZpLogonHttpRequest(ClientSessionTag sessionTag)
            : base(sessionTag, "SignInPage")
        {
        }

        #endregion

        #region GetResponse
        /// <summary>
        /// 处理登录的HTTP请求。
        /// </summary>
        /// <returns>实现了<see cref="IZpHttpResponse"/>接口的对象实例。</returns>
        public override IZpHttpResponse GetResponse()
        {
            HttpWebRequest logonRequest = base.RequestHighpinCn();
            logonRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            base.SetHttpRequestMethod(logonRequest);
            logonRequest.KeepAlive = true;
            logonRequest.AllowAutoRedirect = true;
            byte[] data = this.GetPostData();
            try
            {
                logonRequest.ContentLength = data.Length;
                logonRequest.GetRequestStream().Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new ZpHttpResponseBase((ClientSessionTag)base.SessionTag) { ResponseData = (HttpWebResponse)logonRequest.GetResponse() };
        }
        #endregion

        #region GetPostData
        /// <summary>
        /// 获取提交的数据。
        /// </summary>
        /// <returns>字节数据。</returns>
        private byte[] GetPostData()
        {
            string rawData = string.Format("username={0}&password={1}&postcode={2}&rememberme=false&userType=2");
            return UTF8Encoding.UTF8.GetBytes(rawData);
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