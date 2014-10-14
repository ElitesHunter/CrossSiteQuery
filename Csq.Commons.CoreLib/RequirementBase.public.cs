#region "RequirementBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:38:22
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : RequirementBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.RequirementBase
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
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.RequirementBase</para>
    /// <para>
    /// 搜索条件基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class RequirementBase
    {
        private KeywordsBase _keywords;
        private Gender _gender;
        private AgeBase _ages;
        private WorkExperienceBase _workExperiences;
        private SalaryBase _salary;
        private EducationalBackgroundBase _degree;
        private List<WorkLocationBase> _workLocations;
        private List<PositionBase> _positions;
        private ExpandoRequirementObject _other;

        #region Keywords
        /// <summary>
        /// 设置或获取搜索关键字。
        /// </summary>
        [DataMember]
        public virtual KeywordsBase Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        #endregion

        #region WorkLocations
        /// <summary>
        /// 设置或获取期望工作地点。
        /// </summary>
        [DataMember]
        public virtual List<WorkLocationBase> WorkLocations
        {
            get { return _workLocations; }
            set { _workLocations = value; }
        }
        #endregion

        #region Positions
        /// <summary>
        /// 设置或获取期望职位要求。
        /// </summary>
        [DataMember]
        public virtual List<PositionBase> Positions
        {
            get { return _positions; }
            set { _positions = value; }
        }
        #endregion

        #region Gender
        /// <summary>
        /// 设置或获取性别要求。
        /// </summary>
        [DataMember]
        public virtual Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        #endregion

        #region Ages
        /// <summary>
        /// 设置或获取年龄要求。
        /// </summary>
        [DataMember]
        public virtual AgeBase Ages
        {
            get { return _ages; }
            set { _ages = value; }
        }
        #endregion

        #region WorkExperiences
        /// <summary>
        /// 设置或获取工作经验要求。
        /// </summary>
        [DataMember]
        public virtual WorkExperienceBase WorkExperiences
        {
            get { return _workExperiences; }
            set { _workExperiences = value; }
        }
        #endregion

        #region Salary
        /// <summary>
        /// 设置或获取薪资要求。
        /// </summary>
        [DataMember]
        public virtual SalaryBase Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        #endregion

        #region Degree
        /// <summary>
        /// 设置或获取学历要求。
        /// </summary>
        [DataMember]
        public virtual EducationalBackgroundBase Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }
        #endregion

        #region Other
        /// <summary>
        /// 设置或获取搜索渠道自定义的搜索条件。
        /// </summary>
        public virtual ExpandoRequirementObject Other
        {
            get { return _other; }
            set { _other = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="RequirementBase" />对象实例。</para>
        /// </summary>
        public RequirementBase()
        {
        }

        #endregion
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