#region "IZpHttpResponse"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 15:29:05
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : IZpHttpResponse
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.IZpHttpResponse
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

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.IZpHttpResponse</para>
    /// <para>
    /// 用于处理卓聘网HTTP相应的接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IZpHttpResponse
    {
        #region ResponseData
        /// <summary>
        /// 设置或获取相应数据。
        /// </summary>
        HttpWebResponse ResponseData { get; set; }
        #endregion

        #region SessionTag
        /// <summary>
        /// 获取绑定的会话标记。
        /// </summary>
        ISessionTag SessionTag { get; }
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