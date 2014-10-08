#region "ValidatingCodeImageOCR"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 10:35:16
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
 * 
 * ####     Type Name : ValidatingCodeImageOCR
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ValidatingCodeImageOCR
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
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ValidatingCode.ValidatingCodeImageOCR</para>
    /// <para>
    /// 执行验证码图片的OCR。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class ValidatingCodeImageOCR : IValidatingCodeImageOCR
    {
        private int _contentLength;

        [DllImport("AspriseOCR.dll", EntryPoint = "OCR")]
        private static extern IntPtr OCR(string file, int type);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRpart")]
        static extern IntPtr OCRpart(string file, int type, int startX, int startY, int width, int height);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRBarCodes")]
        static extern IntPtr OCRBarCodes(string file, int type);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRpartBarCodes")]
        static extern IntPtr OCRpartBarCodes(string file, int type, int startX, int startY, int width, int height);

        #region ContentLength
        /// <summary>
        /// 获取HTTP响应流的长度。
        /// </summary>
        public int ContentLength
        {
            get { return _contentLength; }
            private set { _contentLength = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ValidatingCodeImageOCR" />对象实例。</para>
        /// </summary>
        /// <param name="contentLength">HTTP响应流的长度。</param>
        public ValidatingCodeImageOCR(int contentLength)
        {
            this.ContentLength = contentLength;
        }

        #endregion

        #region BuiltImageName
        /// <summary>
        /// 构建验证码图片临时文件名称。
        /// </summary>
        /// <param name="sessionTag">会话标记。</param>
        /// <returns>文件名称。</returns>
        public string BuiltImageName(ISessionTag sessionTag)
        {
            return string.Format("ZP-VC-{0}-{1}-{2}.jpeg", sessionTag.SessionId, Guid.NewGuid(), DateTime.Now.Ticks);
        }
        #endregion

        #region SaveInPhysicalDisk
        /// <summary>
        /// 保存到服务器物理硬盘中的临时目录路径。
        /// </summary>
        /// <param name="imageStream">来自HTTP相应的图片流。</param>
        /// <param name="fileName">文件名称。</param>
        public void SaveInPhysicalDisk(Stream imageStream, string fileName)
        {
            using (Bitmap image = new Bitmap(imageStream))
            {
                try
                {
                    image.Save(fileName);
                }
                catch (Exception ex) { throw ex; }
                finally
                {
                    imageStream.Close();
                }
            }
        }
        #endregion

        #region ExecuteOCR
        /// <summary>
        /// 执行OCR。
        /// </summary>
        /// <param name="fileName">验证码临时文件名称。</param>
        /// <returns>验证码。</returns>
        public string ExecuteOCR(string fileName)
        {
            string validatingCode = Marshal.PtrToStringAnsi(ValidatingCodeImageOCR.OCR(fileName, -1));
            try
            {
                //File.Delete(fileName);
            }
            catch { }
            return this.AdjustOCRchars(validatingCode);
        }
        #endregion

        #region AdjustOCRchars
        /// <summary>
        /// 矫正经过OCR获取的验证码。
        /// </summary>
        /// <param name="validatingCode">验证码。</param>
        /// <returns>验证码。</returns>
        private string AdjustOCRchars(string validatingCode)
        {
            string charseq = ZpConfigurationManager.GetConfig().LegalValidatingCodeSequence.Chars.ToLower();
            char[] inArray = validatingCode.ToCharArray();
            List<char> list = new List<char>();
            foreach (char item in inArray)
            {
                if (charseq.Contains(item.ToString().ToLower())) list.Add(item);
            }
            return new string(list.ToArray());
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