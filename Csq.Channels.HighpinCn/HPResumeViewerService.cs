#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-11-18 10:46:49
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
    /// 类型名称：<see cref="HPResumeViewerService"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 查看智联卓聘网简历详情的服务。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class HPResumeViewerService : IResumeViewerService
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HPResumeViewerService" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HPResumeViewerService()
        { }

        #endregion

        #region GetResumeHtml
        /// <summary>
        /// 获取简历的HTML表达式。
        /// </summary>
        /// <param name="args">查看简历详情所需的参数。</param>
        /// <param name="sessionID">会话标记。</param>
        /// <returns>HTML字符串表达式。</returns>
        public string GetResumeHtml(ResumeDetailViewerArgs args, Guid sessionID)
        {
            ResumeDetailsMessageProcessor processor = new ResumeDetailsMessageProcessor(args.DetailPageUrl, sessionID);
            return processor.SendAndGet().ResumeHtml;
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