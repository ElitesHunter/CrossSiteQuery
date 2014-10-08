#region "ValidatingCodeHttpRequestHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 11:11:08
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
 * 
 * ####     Type Name : ValidatingCodeHttpRequestHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ValidatingCodeHttpRequestHandler
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

namespace MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ValidatingCodeHttpRequestHandler</para>
    /// <para>
    /// 处理验证码请求。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ValidatingCodeHttpRequestHandler : ZpHttpRequestHandlerBase<string>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ValidatingCodeHttpRequestHandler" />对象实例。</para>
        /// </summary>
        public ValidatingCodeHttpRequestHandler()
            : base()
        {
        }

        #endregion

        #region BuiltResult
        /// <summary>
        /// 构建请求结果。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <param name="response"><see cref="HttpWebResponse"/>对象实例。</param>
        /// <returns>验证码。</returns>
        protected override string BuiltResult(ClientSessionTag sessionTag, HttpWebResponse response)
        {
            string validatingCode = string.Empty;
            using (Stream responseStream = response.GetResponseStream())
            {
                IValidatingCodeImageOCR ocr = new ValidatingCodeImageOCR((int)response.ContentLength);
                string fileName = ocr.BuiltImageName(sessionTag);
                fileName = Path.Combine(TemporaryDirectoryInfo.Directory.Path, fileName);
                try
                {
                    ocr.SaveInPhysicalDisk(responseStream, fileName);
                    validatingCode = ocr.ExecuteOCR(fileName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return validatingCode;
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