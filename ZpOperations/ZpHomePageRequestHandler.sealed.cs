#region "ZpHomePageRequestHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 15:31:01
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpHomePageRequestHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpHomePageRequestHandler
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
using System.Text;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpHomePageRequestHandler</para>
    /// <para>
    /// 处理卓聘网首页请求的类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ZpHomePageRequestHandler : ZpHttpRequestHandlerBase<string>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpHomePageRequestHandler" />对象实例。</para>
        /// </summary>
        public ZpHomePageRequestHandler()
        {
        }

        #endregion

        #region BuiltResult
        /// <summary>
        /// 获取卓聘网首页的HTML表达式。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response"><see cref="HttpWebResponse"/>对象实例。</param>
        /// <returns>HTML字符串表达式。</returns>
        protected override string BuiltResult(ClientSessionTag sessionTag, HttpWebResponse response)
        {
            string htmlExpr = string.Empty;
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader streamReader = new StreamReader(responseStream))
                {
                    try
                    {
                        htmlExpr = streamReader.ReadToEnd();
                    }
                    catch (Exception ex) { throw ex; }
                    finally
                    {
                        streamReader.Close();
                        responseStream.Close();
                    }
                }
            }
            return htmlExpr;
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