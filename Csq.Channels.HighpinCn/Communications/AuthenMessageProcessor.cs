#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 15:26:54
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
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="AuthenMessageProcessor"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于处理智联卓聘网身份认证消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    public sealed class AuthenMessageProcessor
        : MasterDuner.Cooperations.Csq.Commons.Communications.CommunicationMessageProcessor<AuthenRequestMessage, AuthenResponseMessage>
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="AuthenMessageProcessor" />对象实例。
        /// </summary>
        /// <param name="sessionID">会话标识。</param>
        /// <param name="credentials">智联卓聘网身份认证凭据。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public AuthenMessageProcessor(Guid sessionID, HPCredentials credentials)
            : base(new AuthenRequestMessage(sessionID, credentials))
        { }

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