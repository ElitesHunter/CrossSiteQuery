#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-29 15:37:43
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
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ResumeSearchMessageProcessor"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.Communications"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于处理简历搜索请求消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    internal sealed class ResumeSearchMessageProcessor : CommunicationMessageProcessor<ResumeSearchRequestMessage, ResumeSearchResponseMessage>
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResumeSearchMessageProcessor" />对象实例。
        /// </summary>
        /// <param name="sessionID">会话标记。</param>
        /// <param name="searchParameter">智联卓品搜索参数。</param>
        /// <param name="paging">分页信息。</param>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        internal ResumeSearchMessageProcessor(Guid sessionID, HPRequirement searchParameter, ResultPage paging)
            : base(new ResumeSearchRequestMessage(sessionID) { SearchParameter = searchParameter, Paging = paging })
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