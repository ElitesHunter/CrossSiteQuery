#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-29 15:43:30
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
using System.ServiceModel.Activation;
using MasterDuner.Cooperations.Csq.Channels.Communications;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="HPResumeSearcher"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 搜索智联卓聘网提供的简历。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public sealed class HPResumeSearcher : IResumeSearcher
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HPResumeSearcher" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HPResumeSearcher()
        { }

        #endregion

        #region Get
        /// <summary>
        /// 执行搜索并获取结果。
        /// </summary>
        /// <param name="sessionID">会话标记。</param>
        /// <param name="channel">搜索通道。</param>
        /// <param name="conditions">搜索条件。</param>
        /// <param name="Page">分页信息。</param>
        /// <returns>搜索结果。</returns>
        public SearchResultBase Get(Guid sessionID, SearchChannels channel, RequirementBase conditions, ResultPage Page)
        {
            ResumeSearchResponseMessage message = new ResumeSearchMessageProcessor(sessionID, conditions as HPRequirement, Page).SendAndGet();
            return new HPSearchResult() { IsSuccessful = true, Status = PerformStatus.Completed, DataExpression = message.HTML };
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