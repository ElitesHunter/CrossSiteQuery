#region "IValidatingCodeImageOCR"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 10:20:15
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
 * 
 * ####     Type Name : IValidatingCodeImageOCR
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.IValidatingCodeImageOCR
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

using System.IO;

namespace MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.IValidatingCodeImageOCR</para>
    /// <para>
    /// 用于处理验证码图片文件（OCR）处理。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IValidatingCodeImageOCR
    {
        #region BuiltImageName
        /// <summary>
        /// 构建文件名称。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>临时文件名称。</returns>
        string BuiltImageName(ISessionTag sessionTag);
        #endregion

        #region SaveInPhysicalDisk
        /// <summary>
        /// 保存到物理硬盘中的临时目录。
        /// </summary>
        /// <param name="imageStream"></param>
        /// <param name="fileName"></param>
        void SaveInPhysicalDisk(Stream imageStream, string fileName);
        #endregion

        #region ExecuteOCR
        /// <summary>
        /// 执行OCR并获取验证码。
        /// </summary>
        /// <param name="fileName">临时文件名称。</param>
        /// <returns>验证码。</returns>
        string ExecuteOCR(string fileName);
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