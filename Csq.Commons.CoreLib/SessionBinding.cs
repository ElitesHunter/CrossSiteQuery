#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 10:01:22
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

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="SessionBinding"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Commons"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于创建绑定客户端与搜索服务间的会话。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class SessionBinding : ISessionBinding
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="SessionBinding" />对象实例。
        /// </summary>
        public SessionBinding()
        { }

        #endregion

        #region CreateSession
        /// <summary>
        /// 创建一个会话标记。
        /// </summary>
        /// <returns><see cref="Guid"/>类型的会话标记。</returns>
        public Guid CreateSession()
        {
            return Guid.NewGuid();
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