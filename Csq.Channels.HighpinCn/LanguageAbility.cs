#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 15:04:54
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
    /// 类型名称：<see cref="LanguageAbility"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 智联卓聘网语言能力要求。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public sealed class LanguageAbility
    {
        private LanguageAbilityDescription _value = LanguageAbilityDescription.All;
        private string _language;

        #region Value
        /// <summary>
        /// 设置或获取语言能力描述。
        /// </summary>
        [DataMember]
        public LanguageAbilityDescription Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Language
        /// <summary>
        /// 设置或获取语言名称。
        /// </summary>
        [DataMember]
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="LanguageAbility" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public LanguageAbility()
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