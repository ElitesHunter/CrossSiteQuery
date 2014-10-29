#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 15:24:41
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
using System.Text;
using MasterDuner.Cooperations.Csq.Channels.RegExpressions;
using MasterDuner.Cooperations.Csq.Commons;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="HPRequirement"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 智联卓聘网搜索条件。
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
    public sealed class HPRequirement : RequirementBase
    {
        #region Private
        /// <summary>
        /// 设置或获取智联卓聘网私有搜索条件。
        /// </summary>
        [DataMember]
        public HPExpandoRequirementObject Private
        {
            get { return base.Other as HPExpandoRequirementObject; }
            set { base.Other = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HPRequirement" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HPRequirement()
        { }

        #endregion

        #region GetKeywords
        /// <summary>
        /// 获取搜索关键字。
        /// </summary>
        /// <returns>搜索关键字。</returns>
        internal string GetKeywords()
        {
            string value = object.ReferenceEquals(this.Keywords, null) ? string.Empty : this.Keywords.Keywords;
            return string.IsNullOrEmpty(value) ? string.Empty : value;
        }
        #endregion

        #region GetGender
        /// <summary>
        /// 获取性别标识。
        /// </summary>
        /// <returns>性别标识值。</returns>
        internal int GetGender()
        {
            int value = (int)this.Gender;
            return value.Equals(65535) ? -1 : value;
        }
        #endregion

        #region GetAgeSegment
        /// <summary>
        /// 获取年龄区段。
        /// </summary>
        /// <returns><see cref="AgeBase"/>对象实例。</returns>
        internal AgeBase GetAgeSegment()
        {
            return !object.ReferenceEquals(this.Ages, null) ? this.Ages : new AgeBase() { Lower = -1, Upper = -1 };
        }
        #endregion

        #region GetWorkExperienceSegment
        /// <summary>
        /// 获取工作经验年限区段值。
        /// </summary>
        /// <returns><see cref="WorkExperienceBase"/>对象实例。</returns>
        internal WorkExperienceBase GetWorkExperienceSegment()
        {
            return !object.ReferenceEquals(this.WorkExperiences, null) ? this.WorkExperiences : new WorkExperienceBase() { Lower = -1, Upper = -1 };
        }
        #endregion

        #region GetMinDegreeID
        /// <summary>
        /// 获取最低学历标识值。
        /// </summary>
        /// <returns>最低序列标识。</returns>
        internal int GetMinDegreeID()
        {
            return
                object.ReferenceEquals(this.Degree, null)
                || object.ReferenceEquals(this.Degree.JuniorDegree, null)
                || string.IsNullOrEmpty(this.Degree.JuniorDegree.InnerId)
                || !new NumberExpression().IsMatch(this.Degree.JuniorDegree.InnerId)
                ? -1
                : int.Parse(this.Degree.JuniorDegree.InnerId);
        }
        #endregion

        #region GetMaxDegreeID
        /// <summary>
        /// 获取最高序列标识。
        /// </summary>
        /// <returns>最高序列标识值。</returns>
        internal int GetMaxDegreeID()
        {
            return
                object.ReferenceEquals(this.Degree, null)
                || object.ReferenceEquals(this.Degree.SeniorDegree, null)
                || string.IsNullOrEmpty(this.Degree.SeniorDegree.InnerId)
                || !new NumberExpression().IsMatch(this.Degree.SeniorDegree.InnerId)
                ? -1
                : int.Parse(this.Degree.SeniorDegree.InnerId);
        }
        #endregion

        #region GetWorkLocationStr
        /// <summary>
        /// 获取期望工作地点字符串表达式。
        /// </summary>
        /// <returns>期望工作地点。</returns>
        internal string GetWorkLocationStr()
        {
            ExpressionBase reg = new HPIdExpression();
            StringBuilder s = new StringBuilder();
            if (!object.ReferenceEquals(this.WorkLocations, null))
            {
                for (int i = 0; i < this.WorkLocations.Count; i++)
                {
                    if (i >= 3) break;
                    if (!string.IsNullOrWhiteSpace(this.WorkLocations[i].InnerId) && reg.IsMatch(this.WorkLocations[i].InnerId))
                        s.AppendFormat("{0}{1}", this.WorkLocations[i].InnerId, !i.Equals(0) ? "," : string.Empty);
                }
            }
            return s.ToString();
        }
        #endregion

        #region GetJobTypeStr
        /// <summary>
        /// 获取期望工作职位字符串表达式。
        /// </summary>
        /// <returns>期望工作职位字符串表达式。</returns>
        internal string GetJobTypeStr()
        {
            ExpressionBase reg = new HPIdExpression();
            StringBuilder s = new StringBuilder();
            if (!object.ReferenceEquals(this.Positions, null))
            {
                for (int i = 0; i < this.Positions.Count; i++)
                {
                    if (i >= 3) break;
                    if (!string.IsNullOrWhiteSpace(this.Positions[i].InnerId) && reg.IsMatch(this.Positions[i].InnerId))
                        s.AppendFormat("{0}{1}", this.Positions[i].InnerId, !i.Equals(0) ? "," : string.Empty);
                }
            }
            return s.ToString();
        }
        #endregion

        #region GetResumeNumber
        /// <summary>
        /// 获取输入的简历编号。
        /// </summary>
        /// <returns>简历编号。</returns>
        internal string GetResumeNumber()
        {
            return object.ReferenceEquals(this.Private, null) || string.IsNullOrWhiteSpace(this.Private.SnOfResume) ? string.Empty : this.Private.SnOfResume;
        }
        #endregion

        #region GetWhetherIncludeOverseasMark
        /// <summary>
        /// 获取是否包含海外工作经历标记。
        /// </summary>
        /// <returns>是否包含标记。</returns>
        internal int GetWhetherIncludeOverseasMark()
        {
            return object.ReferenceEquals(this.Private, null) ? 0 : (int)this.Private.OverseasWorkingExperienceRequired;
        }
        #endregion

        #region GetLanguageAbilityStr
        /// <summary>
        /// 获取语言能力字符串表达式。
        /// </summary>
        /// <returns>字符串表达式。</returns>
        internal string GetLanguageAbilityStr()
        {
            ExpressionBase reg = new NumberExpression();
            StringBuilder s = new StringBuilder("Language=-1");
            if (!object.ReferenceEquals(this.Private, null) && !object.ReferenceEquals(this.Private.LanguageAbilities, null) && this.Private.LanguageAbilities.Count >= 1)
            {
                int i = 0;
                for (; i < this.Private.LanguageAbilities.Count; i++)
                {
                    if (i >= 3) break;
                    s.AppendFormat("&Language{0}={1}&Ability{0}={2}", i + 1, this.Private.LanguageAbilities[i].InnerId, (int)this.Private.LanguageAbilities[i].Value);
                }
                for (; i < 3; i++)
                {
                    s.AppendFormat("&Language{0}=-1&Ability{0}=-1", i + 1);
                }
            }
            else
                s.Append("&Language1=-1&Ability1=-1&Language2=-1&Ability2=-1&Language3=-1&Ability3=-1");
            return s.ToString();
        }
        #endregion

        #region GetProfessionName
        /// <summary>
        /// 获取专业名称。
        /// </summary>
        /// <returns>专业名称。</returns>
        internal string GetProfessionName()
        {
            return object.ReferenceEquals(this.Private, null) || string.IsNullOrWhiteSpace(this.Private.ProfessionName) ? string.Empty : this.Private.ProfessionName;
        }
        #endregion

        #region GetSchoolName
        /// <summary>
        /// 获取就读学校名称。
        /// </summary>
        /// <returns>学校名称。</returns>
        internal string GetSchoolName()
        {
            return object.ReferenceEquals(this.Private, null) || string.IsNullOrWhiteSpace(this.Private.SchoolName) ? string.Empty : this.Private.SchoolName;
        }
        #endregion

        #region GetResidencesStr
        /// <summary>
        /// 获取居住地的字符串表达式。
        /// </summary>
        /// <returns>居住地编码字符串表达式。</returns>
        internal string GetResidencesStr()
        {
            ExpressionBase reg = new HPIdExpression();
            StringBuilder s = new StringBuilder();
            if (!object.ReferenceEquals(this.Private, null) && !object.ReferenceEquals(this.Private.Residences, null) && this.Private.Residences.Count > 0)
            {
                for (int i = 0; i < this.Private.Residences.Count; i++)
                {
                    if (!string.IsNullOrWhiteSpace(this.Private.Residences[i].InnerId) && reg.IsMatch(this.Private.Residences[i].InnerId))
                    {
                        s.AppendFormat("{0}{1}", this.Private.Residences[i].InnerId, i.Equals(0) ? string.Empty : ",");
                    }
                }
            }
            return s.ToString();
        }
        #endregion

        #region GetIndustriesStr
        /// <summary>
        /// 获取行业信息字符串表达式。
        /// </summary>
        /// <returns>行业信息字符串表达式。</returns>
        internal string GetIndustriesStr()
        {
            ExpressionBase reg = new HPIdExpression();
            StringBuilder s = new StringBuilder();
            if (!object.ReferenceEquals(this.Private, null) && !object.ReferenceEquals(this.Private.Industries, null) && this.Private.Industries.Count > 0)
            {
                for (int i = 0; i < this.Private.Industries.Count; i++)
                {
                    if (!string.IsNullOrWhiteSpace(this.Private.Industries[i].InnerId) && reg.IsMatch(this.Private.Industries[i].InnerId))
                    {
                        s.AppendFormat("{0}{1}", this.Private.Industries[i].InnerId, i.Equals(0) ? string.Empty : ",");
                    }
                }
            }
            return s.ToString();
        }
        #endregion

        #region GetCorporationName
        /// <summary>
        /// 获取公司名称。
        /// </summary>
        /// <returns>公司名称。</returns>
        internal string GetCorporationName()
        {
            return object.ReferenceEquals(this.Private, null) || string.IsNullOrWhiteSpace(this.Private.Corporation) ? string.Empty : this.Private.Corporation;
        }
        #endregion

        #region GetWhetherLastestMark
        /// <summary>
        /// 获取是否需要最近工作过的公司数据。
        /// </summary>
        /// <returns>标记。</returns>
        internal bool GetWhetherLastestMark()
        {
            return object.ReferenceEquals(this.Private, null) ? false : this.Private.Lastest;
        }
        #endregion

        #region GetWorkingStatus
        /// <summary>
        /// 获取工作状态标记值。
        /// </summary>
        /// <returns>工作状态值。</returns>
        internal int GetWorkingStatus()
        {
            return object.ReferenceEquals(this.Private, null) ? -1 : (int)this.Private.WorkingStatus;
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