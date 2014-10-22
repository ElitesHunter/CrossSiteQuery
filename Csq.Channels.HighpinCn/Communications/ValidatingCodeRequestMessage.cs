#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-22 11:11:58
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
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Channels.Configuration;
using MasterDuner.Cooperations.Csq.Commons.Configuration;
using MasterDuner.Cooperations.Csq.Commons;
using System.Net;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ValidatingCodeRequestMessage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 验证码请求消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    internal sealed class ValidatingCodeRequestMessage : HttpWebRequestMessage
    {
        private HPSection _config;

        #region Url
        /// <summary>
        /// 获取需要请求的验证码URL。
        /// </summary>
        protected override string Url
        {
            get
            {
                return string.Format(_config.ActionUrls["ValidatingCode"].BaseUrl, JavaScriptDateCompatible.GetTimeTicks(DateTime.Now));
            }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ValidatingCodeRequestMessage" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal ValidatingCodeRequestMessage()
            : base(Guid.Empty)
        {
            _config = new PrivateConfiguration(SearchChannels.HighpinCn).GetSection<HPSection>("www.highpin.cn");
            this.Method = CommunicationMethods.HttpGet;
        }

        #endregion

        #region GetValidatingCodeResponse
        /// <summary>
        /// 获取验证码相应消息。
        /// </summary>
        /// <returns><see cref="ValidatingCodeResponseMessage"/>对象实例。</returns>
        private ValidatingCodeResponseMessage GetValidatingCodeResponse()
        {
            HttpWebRequest request = this.CreateHttpRequest();
            ValidatingCodeResponseMessage message = new ValidatingCodeResponseMessage(request.GetResponse() as HttpWebResponse);
            message.Init();
            return message;
        }
        #endregion

        #region GetResponse
        /// <summary>
        /// 获取验证码响应消息。
        /// </summary>
        /// <typeparam name="TResponse"><see cref="ValidatingCodeResponseMessage"/>。</typeparam>
        /// <returns><see cref="ValidatingCodeResponseMessage"/>对象实例。</returns>
        protected override TResponse GetResponse<TResponse>()
        {
            return this.GetValidatingCodeResponse() as TResponse;
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