#region "IndustryHttpRequest"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 16:33:37
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : IndustryHttpRequest
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryHttpRequest
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

namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryHttpRequest</para>
    /// <para>
    /// 用于请求卓聘网的行业参数数据。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class IndustryHttpRequest : ZpHttpRequestBase
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="IndustryHttpRequest" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        public IndustryHttpRequest(ClientSessionTag sessionTag)
            : base(sessionTag, "ParametersData")
        {
            base.Url.Url = string.Format(base.Url.Url, DateTime.Now.AddDays(-1).ToString("yyyyMMddHHmmss"));
        }

        #endregion

        #region GetResponse
        /// <summary>
        /// 发送请求，并获取相应数据。
        /// </summary>
        /// <returns>实现了<see cref="IZpHttpResponse"/>接口的对象实例。</returns>
        public override IZpHttpResponse GetResponse()
        {
            HttpWebRequest request = base.RequestHighpinCn();
            request.KeepAlive = true;
            request.AllowAutoRedirect = true;
            request.CookieContainer = base.GetCookieContainer();
            base.SetHttpRequestMethod(request);
            return new ZpHttpResponseBase((ClientSessionTag)base.SessionTag) { ResponseData = (HttpWebResponse)request.GetResponse() };
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