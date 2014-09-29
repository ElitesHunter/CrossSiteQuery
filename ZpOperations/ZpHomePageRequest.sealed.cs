#region "ZpHomePageRequest"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 14:49:33
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpHomePageRequest
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpHomePageRequest
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

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpHomePageRequest</para>
    /// <para>
    /// 尝试请求卓聘网的首页，获取相关信息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ZpHomePageRequest : ZpHttpRequestBase
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHomePageRequest" />对象实例。</para>
        /// </summary>
        public ZpHomePageRequest(ClientSessionTag sessionTag)
            : base(sessionTag, "HomePage")
        {
        }

        #endregion

        #region GetResponse
        /// <summary>
        /// 获取卓聘网响应数据。
        /// </summary>
        /// <returns><see cref="ZpHttpResponseBase"/></returns>
        public override IZpHttpResponse GetResponse()
        {
            HttpWebRequest zpRequest = base.RequestHighpinCn();
            zpRequest.ContentType = "text/html; charset=utf-8";
            zpRequest.CookieContainer = base.GetCookieContainer();
            base.SetHttpRequestMethod(zpRequest);
            zpRequest.KeepAlive = true;
            zpRequest.AllowAutoRedirect = false;
            return new ZpHttpResponseBase((ClientSessionTag)this.SessionTag) { ResponseData = (HttpWebResponse)zpRequest.GetResponse() };
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