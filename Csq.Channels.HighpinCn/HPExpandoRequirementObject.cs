#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 14:25:46
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
using MasterDuner.Cooperations.Csq.Commons;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="HPExpandoRequirementObject"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>定义了智联卓聘网独有的搜索条件对象。</para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public sealed class HPExpandoRequirementObject : ExpandoRequirementObject
    {
        private string _snOfResume;
        private OverseasWorkingExperienceRequired _overseasWorkingExperienceRequired = OverseasWorkingExperienceRequired.All;
        private List<LanguageAbility> _languageAbilities;
        private string _professionName;
        private string _schoolName;
        private List<ResidenceLocation> _residences;
        private List<Industry> _industries;
        private string _corporation;
        private bool _lastest = false;

        #region SnOfResume
        /// <summary>
        /// 设置或获取简历编号。
        /// </summary>
        [DataMember]
        public string SnOfResume
        {
            get { return _snOfResume; }
            set { _snOfResume = value; }
        }
        #endregion

        #region OverseasWorkingExperienceRequired
        /// <summary>
        /// 设置或获取是否必须要求海外工作经验。
        /// </summary>
        public OverseasWorkingExperienceRequired OverseasWorkingExperienceRequired
        {
            get { return _overseasWorkingExperienceRequired; }
            set { _overseasWorkingExperienceRequired = value; }
        }
        #endregion

        #region LanguageAbilities
        /// <summary>
        /// 设置或获取语言能力要求。
        /// </summary>
        [DataMember]
        public List<LanguageAbility> LanguageAbilities
        {
            get { return _languageAbilities; }
            set { _languageAbilities = value; }
        }
        #endregion

        #region ProfessionName
        /// <summary>
        /// 设置或获取专业名称。
        /// </summary>
        [DataMember]
        public string ProfessionName
        {
            get { return _professionName; }
            set { _professionName = value; }
        }
        #endregion

        #region SchoolName
        /// <summary>
        /// 设置或获取学校名称。
        /// </summary>
        [DataMember]
        public string SchoolName
        {
            get { return _schoolName; }
            set { _schoolName = value; }
        }
        #endregion

        #region Residences
        /// <summary>
        /// 设置或获取居住地。
        /// </summary>
        [DataMember]
        public List<ResidenceLocation> Residences
        {
            get { return _residences; }
            set { _residences = value; }
        }
        #endregion

        #region Industries
        /// <summary>
        /// 设置或获取行业搜索条件。
        /// </summary>
        [DataMember]
        public List<Industry> Industries
        {
            get { return _industries; }
            set { _industries = value; }
        }
        #endregion

        #region Corporation
        /// <summary>
        /// 设置或获取公司名称关键字。
        /// </summary>
        [DataMember]
        public string Corporation
        {
            get { return _corporation; }
            set { _corporation = value; }
        }
        #endregion

        #region Lastest
        /// <summary>
        /// 设置或获取是否为最近的一份工作。
        /// </summary>
        [DataMember]
        public bool Lastest
        {
            get { return _lastest; }
            set { _lastest = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HPExpandoRequirementObject" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HPExpandoRequirementObject()
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