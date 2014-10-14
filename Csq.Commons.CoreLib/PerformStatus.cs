#region "PerformStatus"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 13:47:06
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : PerformStatus
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.PerformStatus
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
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.PerformStatus</para>
    /// <para>
    /// 搜索执行结果枚举类型。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    [DataContract]
    public enum PerformStatus
    {
        /// <summary>
        /// 成功完成搜索。
        /// </summary>
        [EnumMember]
        Completed = 65535,
        /// <summary>
        /// 错误的HTTP请求。
        /// </summary>
        [EnumMember]
        HttpError = 1024,
        /// <summary>
        /// 错误的验证码。
        /// </summary>
        [EnumMember]
        FailedValidatingCode = 1025,
        /// <summary>
        /// 错误的身份认证凭据。
        /// </summary>
        [EnumMember]
        FailedCredentials = 1026,
        /// <summary>
        /// 错误的搜索参数。
        /// </summary>
        [EnumMember]
        FailedSearchArguments = 1027,
        /// <summary>
        /// 未知的错误。
        /// </summary>
        [EnumMember]
        UnknownError = 2048
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