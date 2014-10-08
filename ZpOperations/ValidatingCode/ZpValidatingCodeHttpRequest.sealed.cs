#region "ZpValidatingCodeHttpRequest"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 10:51:17
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
 * 
 * ####     Type Name : ZpValidatingCodeHttpRequest
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ZpValidatingCodeHttpRequest
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

namespace MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ZpValidatingCodeHttpRequest</para>
    /// <para>
    /// 用于请求卓聘网的验证码。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ZpValidatingCodeHttpRequest : ZpHttpRequestBase
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpValidatingCodeHttpRequest" />对象实例。</para>
        /// </summary>
        /// <param name="sessionTag">请求标记。</param>
        public ZpValidatingCodeHttpRequest(ClientSessionTag sessionTag)
            : base(sessionTag, "ValidatingCode")
        {
            base.Url.Url = string.Format(base.Url.Url, DateTime.Now.Ticks);
        }

        #endregion

        #region GetResponse
        /// <summary>
        /// 获取HTTP相应。
        /// </summary>
        /// <returns>实现了<see cref="IZpHttpResponse"/>接口的对象实例。</returns>
        public override IZpHttpResponse GetResponse()
        {
            HttpWebRequest vcRequest = base.RequestHighpinCn();
            vcRequest.Accept = "image/png,image/*,q=0.8,*/*;q=0.5";
            vcRequest.CookieContainer = base.GetCookieContainer();
            base.SetHttpRequestMethod(vcRequest);
            vcRequest.KeepAlive = true;
            vcRequest.AllowAutoRedirect = true;
            return new ZpHttpResponseBase((ClientSessionTag)this.SessionTag) { ResponseData = (HttpWebResponse)vcRequest.GetResponse() };
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