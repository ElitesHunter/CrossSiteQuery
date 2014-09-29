#region "ZpHttpResponseBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:00:37
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpHttpResponseBase
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpHttpResponseBase
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpHttpResponseBase</para>
    /// <para>
    /// 卓聘网HTTP相应基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class ZpHttpResponseBase : IZpHttpResponse
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHttpResponseBase" />对象实例。</para>
        /// </summary>
        public ZpHttpResponseBase()
        {
        }

        #endregion

        #region ResponseData
        private HttpWebResponse _response;
        /// <summary>
        /// 设置或获取HTTP相应数据。
        /// </summary>
        public virtual HttpWebResponse ResponseData
        {
            get
            {
                return this._response;
            }
            set
            {
                this._response = value;
            }
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