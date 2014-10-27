#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-22 10:39:40
 * 
 * Machine Name : GLCHQWYCWINW7
 * 
 * Current User : GUOCOLAND/wangyucai
 * 
 * CLR Version : 4.0.30319.18444
 * 
 * Target Framework : This type is available for 4.0 and above versions of .NET Framework.
 */

#endregion

using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using MasterDuner.Cooperations.Csq.Channels.Configuration;
using MasterDuner.Cooperations.Csq.Commons.Configuration;
using MasterDuner.Cooperations.Csq.Channels.RegExpressions;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ValidatingCodeImageProcessor"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 执行对验证码图片的OCR操作。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    internal sealed class ValidatingCodeImageProcessor
    {
        private Stream _imageStream;
        private string _temporaryName;
        private static readonly HPSection Config = new PrivateConfiguration(Commons.SearchChannels.HighpinCn).GetSection<HPSection>("www.highpin.cn");

        #region OCR Dll Import

        [DllImport("AspriseOCR.dll", EntryPoint = "OCR")]
        private static extern IntPtr OCR(string file, int type);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRpart")]
        static extern IntPtr OCRpart(string file, int type, int startX, int startY, int width, int height);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRBarCodes")]
        static extern IntPtr OCRBarCodes(string file, int type);

        [DllImport("AspriseOCR.dll", EntryPoint = "OCRpartBarCodes")]
        static extern IntPtr OCRpartBarCodes(string file, int type, int startX, int startY, int width, int height);

        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ValidatingCodeImageProcessor" />对象实例。
        /// </summary>
        /// <param name="imageStream">验证码图片流。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal ValidatingCodeImageProcessor(Stream imageStream)
        {
            this._imageStream = imageStream;
            this._temporaryName = string.Format("ZLZP-VC-{0}-{1}-{2}-TEMP.jpeg", Guid.NewGuid(), DateTime.Now.Ticks, new Random().Next(9999));
        }

        #endregion

        #region SaveToPhysicalDisk
        /// <summary>
        /// 保存验证码图片到物理硬盘中。
        /// </summary>
        /// <returns>是否保存成功。</returns>
        private bool SaveToPhysicalDisk()
        {
            bool successful = true;
            using (Bitmap image = new Bitmap(this._imageStream))
            {
                try
                {
                    image.Save(Path.Combine(TemporaryDirectoryInfo.This.Path, this._temporaryName));
                }
                catch(Exception ex)
                {
                    successful = false;
                }
                finally
                {
                    this._imageStream.Close();
                }
            }
            return successful;
        }
        #endregion

        #region GetValidatingCode
        /// <summary>
        /// 执行OCR并获取验证码。
        /// </summary>
        /// <returns>验证码。</returns>
        internal string GetValidatingCode()
        {
            if (this.SaveToPhysicalDisk())
            {
                string vCode = Marshal.PtrToStringAnsi(OCR(Path.Combine(TemporaryDirectoryInfo.This.Path, this._temporaryName), -1));
                ValidatingCodeTextExpression expr = new ValidatingCodeTextExpression();
                if (expr.IsMatch(vCode))
                    vCode = expr.Match(vCode).Value;
                this.DeleteTemporaryImage();
                return vCode;
            }
            return string.Empty;
        }
        #endregion

        #region DeleteTemporaryImage
        /// <summary>
        /// 删除临时文件。
        /// </summary>
        private void DeleteTemporaryImage()
        {
            try
            {
                if (Config.ValidatingCodeImage.AutoDelete)
                    File.Delete(Path.Combine(TemporaryDirectoryInfo.This.Path, this._temporaryName));
            }
            catch { }
        }
        #endregion
    }
}

#region Contact me

/*
 * E-mail Address : Masterduner@Yeah.net or Yucai.Wang-Public@Outlook.com
 * 
 * Mobile : +86 13621384677
 * 
 * QQ : 180261899
 */

#endregion

/* Copyright © 2014 Wang Yucai. All rights reserved. */