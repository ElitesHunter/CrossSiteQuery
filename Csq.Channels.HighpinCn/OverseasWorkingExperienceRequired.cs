#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 14:30:27
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
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="OverseasWorkingExperienceRequired"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 是否要求海外工作经验枚举类型。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public enum OverseasWorkingExperienceRequired
    {
        /// <summary>
        /// 不限旳。
        /// </summary>
        [EnumMember]
        All = 0,
        /// <summary>
        /// 必须的。
        /// </summary>
        [EnumMember]
        Necessary = 1,
        /// <summary>
        /// 非必须的。
        /// </summary>
        [EnumMember]
        Unnecessary = 2
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