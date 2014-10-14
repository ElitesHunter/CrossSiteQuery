#region "Gender"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:11:18
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : Gender
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Gender
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.Gender</para>
    /// <para>
    /// 性别要求搜索条件枚举类型。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable()]
    [DataContract]
    public enum Gender
    {
        /// <summary>
        /// 男性。
        /// </summary>
        [EnumMember]
        Man = 1,
        /// <summary>
        /// 女性。
        /// </summary>
        [EnumMember]
        Woman = 2,
        /// <summary>
        /// 不限。
        /// </summary>
        [EnumMember]
        All = 65535,
        /// <summary>
        /// 未知性别。
        /// </summary>
        [EnumMember]
        Unknown = -1
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