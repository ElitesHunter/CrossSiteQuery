#region "IZpHttpRequest"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 15:26:09
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : IZpHttpRequest
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.IZpHttpRequest
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

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.IZpHttpRequest</para>
    /// <para>
    /// 用来模拟发送卓聘网的HTTP请求。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IZpHttpRequest
    {
        #region Url
        /// <summary>
        /// 设置或获取需要请求的URL。
        /// </summary>
        IZpUri Url { get; set; }
        #endregion

        #region Cookies
        /// <summary>
        /// 获取发送到卓聘网的Cookie信息。
        /// </summary>
        IList<IZpCookie> Cookies { get; }
        #endregion

        #region GetResponse
        /// <summary>
        /// 发送HTTP请求，并获取相应。
        /// </summary>
        /// <returns>实现了<see cref="IZpHttpResponse"/>接口的对象实例。</returns>
        IZpHttpResponse GetResponse();
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