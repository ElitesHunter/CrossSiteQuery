#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 10:49:33
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
using MasterDuner.Cooperations.Csq.Channels.Communications;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="HPAuthenService"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 登录智联卓聘网的服务。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class HPAuthenService : IAuthenticationService
    {
        private Guid _sessionID;

        #region SessionID
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        private Guid SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HPAuthenService" />对象实例。
        /// </summary>
        /// <param name="sessionID">会话标记。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HPAuthenService(Guid sessionID)
        {
            this.SessionID = sessionID;
        }

        #endregion

        #region SignIn
        /// <summary>
        /// 登录到智联卓品网。
        /// </summary>
        /// <param name="channel">搜索渠道。</param>
        /// <param name="credentials">搜索渠道身份认证凭据。</param>
        /// <returns>身份认证结果。</returns>
        public AuthenticationResult SignIn(SearchChannels channel, SearchChannelCredentials credentials)
        {
            int status = new AuthenMessageProcessor(this.SessionID, credentials as HPCredentials).SendAndGet().Status;
            while (status == 14 || status == -1)
            {
                status = new AuthenMessageProcessor(this.SessionID, credentials as HPCredentials).SendAndGet().Status;
            }
            return new HPAuthenResult()
            {
                Status = status == 30 ? PerformStatus.Completed : PerformStatus.FailedCredentials,
                AuthenStatus = (HPAuthenStatus)status,
                BindSessionID = this.SessionID,
                IsSuccessful = status.Equals(30)
            };
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