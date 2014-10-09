#region "IndustryHttpRequestHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 16:47:18
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : IndustryHttpRequestHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryHttpRequestHandler
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
using System.IO;
using System.Net;

namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryHttpRequestHandler</para>
    /// <para>
    /// 用于处理行业数据请求。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class IndustryHttpRequestHandler : ZpHttpRequestHandlerBase<IndustryCollection>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="IndustryHttpRequestHandler" />对象实例。</para>
        /// </summary>
        public IndustryHttpRequestHandler()
        {
        }

        #endregion

        #region BuiltResult
        /// <summary>
        /// 用于构建行业数据集合。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response">相应数据。</param>
        /// <returns>行业数据结果。</returns>
        protected override IndustryCollection BuiltResult(ClientSessionTag sessionTag, HttpWebResponse response)
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                try
                {
                    string javascriptData = reader.ReadToEnd();
                    IndustryCollection result = new IndustryCollection() { GroupName = "Industry" };
                    result.InitExpressions();
                    return result.Match(javascriptData);
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