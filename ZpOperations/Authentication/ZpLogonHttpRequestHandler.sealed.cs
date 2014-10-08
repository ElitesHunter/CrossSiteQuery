#region "ZpLogonHttpRequestHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 15:16:27
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Authentication
 * 
 * ####     Type Name : ZpLogonHttpRequestHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Authentication.ZpLogonHttpRequestHandler
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
using System.IO;

namespace MasterDuner.HHProjects.Csq.Highpincn.Authentication
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Authentication.ZpLogonHttpRequestHandler</para>
    /// <para>
    /// 处理卓聘登录请求的相应。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ZpLogonHttpRequestHandler : ZpHttpRequestHandlerBase<string>, IAuthenticate
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpLogonHttpRequestHandler" />对象实例。</para>
        /// </summary>
        public ZpLogonHttpRequestHandler()
            : base()
        {
        }

        #endregion

        #region Credentials
        private ISimulateCredentials _credentials;
        /// <summary>
        /// 设置或获取模拟账户凭据。
        /// </summary>
        public ISimulateCredentials Credentials
        {
            get
            {
                return this._credentials;
            }
            set
            {
                this._credentials = value;
            }
        }
        #endregion

        #region ValidatingCode
        private string _validatingCode;
        /// <summary>
        /// 设置或获取验证码。
        /// </summary>
        public string ValidatingCode
        {
            get
            {
                return this._validatingCode;
            }
            set
            {
                this._validatingCode = value;
            }
        }
        #endregion

        #region Logon
        /// <summary>
        /// 执行登录。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>登录是否成功。</returns>
        public bool Logon(ISessionTag sessionTag)
        {
            string result = this.RequestAndGetResponseData(new ZpLogonHttpRequest((ClientSessionTag)sessionTag)
            {
                UserName = this.Credentials.UserName,
                Password = this.Credentials.Password,
                ValidatingCode = this.ValidatingCode,
                Method = HttpMethods.Post
            });
            return result.Equals("30");
        }
        #endregion

        #region BuiltResult
        /// <summary>
        /// 发送登录请求，并构建结果。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response"><see cref="HttpWebResponse"/>对象实例。</param>
        /// <returns>返回结果。</returns>
        protected override string BuiltResult(ClientSessionTag sessionTag, HttpWebResponse response)
        {
            string responseText = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                try
                {
                    responseText = reader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            return responseText;
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