#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 10:01:18
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
    /// 类型名称：<see cref="HPAuthenStatus"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 定义了智联卓聘网身份认证结果状态。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public enum HPAuthenStatus
    {
        /// <summary>
        /// 错误的用户名密码。
        /// </summary>
        [EnumMember]
        WrongUserNameOrPassword = 2,
        /// <summary>
        /// 错误的验证码。
        /// </summary>
        [EnumMember]
        WrongValidatingCode = 14,
        /// <summary>
        /// 成功登录。
        /// </summary>
        [EnumMember]
        Completed = 30,
        /// <summary>
        /// 未知的。
        /// </summary>
        [EnumMember]
        Unknown = -1
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