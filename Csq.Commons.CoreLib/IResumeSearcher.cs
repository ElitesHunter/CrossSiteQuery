#region "IResumeSearcher"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 14:02:58
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : IResumeSearcher
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.IResumeSearcher
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
using System.ServiceModel;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.IResumeSearcher</para>
    /// <para>
    /// 简历搜索接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IResumeSearcher
    {
        /// <summary>
        /// 执行搜索并获取数据。
        /// </summary>
        /// <param name="sessionID">客户端与搜索服务间的会话标记。</param>
        /// <param name="channel">搜索渠道标记。</param>
        /// <param name="conditions">搜索条件。</param>
        /// <param name="pageSize">每一页的数据个数。</param>
        /// <returns><see cref="SearchResultBase"/>对象实例。</returns>
        [OperationContract]
        SearchResultBase Get(Guid sessionID, SearchChannels channel, RequirementBase conditions, int pageSize);
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