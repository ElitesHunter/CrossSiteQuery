#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 14:38:05
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
    /// 类型名称：<see cref="LanguageAbilityDescription"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于描述语言能力的枚举类型。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public enum LanguageAbilityDescription
    {
        /// <summary>
        /// 不限旳。
        /// </summary>
        [EnumMember]
        All = -1,
        /// <summary>
        /// 一般的。
        /// </summary>
        [EnumMember]
        Ordinary = 1,
        /// <summary>
        /// 良好的。
        /// </summary>
        [EnumMember]
        Well = 2,
        /// <summary>
        /// 熟练地。
        /// </summary>
        [EnumMember]
        Proficient = 3,
        /// <summary>
        /// 精通的。
        /// </summary>
        [EnumMember]
        Versed = 4
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