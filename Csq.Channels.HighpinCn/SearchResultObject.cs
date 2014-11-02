#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-31 11:37:05
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
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using MasterDuner.Cooperations.Csq.Channels.RegExpressions;

namespace MasterDuner.Cooperations.Csq.Channels
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="SearchResultObject"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 结构化搜索结果对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public class SearchResultObject
    {
        private bool _isMatch;
        private string _sourceHtml;
        private string _positionName;
        private string _resumeDetailsUrl;
        private string _corporationName;
        private string _gender;
        private int _age;
        private string _degreeName;
        private string _residence;
        private string _educationalBackground;
        private string _workingExperience;
        private List<string> _resumeTags;
        private string _pictureUrl;

        #region IsMatch
        /// <summary>
        /// 获取是否匹配搜索结果。
        /// </summary>
        [IgnoreDataMember]
        public virtual bool IsMatch
        {
            get { return _isMatch; }
            protected set { _isMatch = value; }
        }
        #endregion

        #region SourceHtml
        /// <summary>
        /// 设置或获取原始的HTML文本。
        /// </summary>
        [IgnoreDataMember]
        protected virtual string SourceHtml
        {
            get { return _sourceHtml; }
            set { _sourceHtml = value; }
        }
        #endregion

        #region PositionName
        /// <summary>
        /// 设置或获取当前的职位名称。
        /// </summary>
        [DataMember]
        public virtual string PositionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }
        #endregion

        #region ResumeDetailsUrl
        /// <summary>
        /// 设置或获取简历详情URL地址。
        /// </summary>
        [DataMember]
        public virtual string ResumeDetailsUrl
        {
            get { return _resumeDetailsUrl; }
            set { _resumeDetailsUrl = value; }
        }
        #endregion

        #region CorporationName
        /// <summary>
        /// 设置或获取当前就职的公司名称。
        /// </summary>
        [DataMember]
        public virtual string CorporationName
        {
            get { return _corporationName; }
            set { _corporationName = value; }
        }
        #endregion

        #region Gender
        /// <summary>
        /// 设置或获取性别。
        /// </summary>
        [DataMember]
        public virtual string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        #endregion

        #region Age
        /// <summary>
        /// 设置或获取年龄。
        /// </summary>
        [DataMember]
        public virtual int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        #endregion

        #region DegreeName
        /// <summary>
        /// 设置或获取学历名称。
        /// </summary>
        [DataMember]
        public virtual string DegreeName
        {
            get { return _degreeName; }
            set { _degreeName = value; }
        }
        #endregion

        #region Residence
        /// <summary>
        /// 设置或获取居住地地址。
        /// </summary>
        [DataMember]
        public virtual string Residence
        {
            get { return _residence; }
            set { _residence = value; }
        }
        #endregion

        #region EducationalBackground
        /// <summary>
        /// 设置或获取教育背景描述信息。
        /// </summary>
        [DataMember]
        public virtual string EducationalBackground
        {
            get { return _educationalBackground; }
            set { _educationalBackground = value; }
        }
        #endregion

        #region WorkingExperience
        /// <summary>
        /// 设置或获取工作经历描述。
        /// </summary>
        [DataMember]
        public virtual string WorkingExperience
        {
            get { return _workingExperience; }
            set { _workingExperience = value; }
        }
        #endregion

        #region ResumeTags
        /// <summary>
        /// 设置或获取简历标签。
        /// </summary>
        [DataMember]
        public virtual List<string> ResumeTags
        {
            get { return _resumeTags; }
            set { _resumeTags = value; }
        }
        #endregion

        #region PictureUrl
        /// <summary>
        /// 设置或获取头像的URL地址。
        /// </summary>
        [DataMember]
        public virtual string PictureUrl
        {
            get { return _pictureUrl; }
            set { _pictureUrl = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="SearchResultObject" />对象实例。
        /// </summary>
        /// <param name="src">原始HTML搜索结果。</param>
        public SearchResultObject(string src)
        {
            this.SourceHtml = src;
            this.IsMatch = new IsSearchResultExpression().IsMatch(src);
        }

        /// <summary>
        /// 初始化一个<see cref="SearchResultObject" />对象实例。
        /// </summary>
        public SearchResultObject()
        {
        }

        #endregion

        #region ParsePositionAndUrl
        /// <summary>
        /// 解析职位名称和简历的URL。
        /// </summary>
        protected virtual void ParsePositionAndUrl()
        {
            JobTitleAndUrlExpression regexpr = new JobTitleAndUrlExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["PositionName"], null) && match.Groups["PositionName"].Success)
                        this.PositionName = match.Groups["PositionName"].Value;
                    if (!object.ReferenceEquals(match.Groups["DetailsUrl"], null) && match.Groups["DetailsUrl"].Success)
                        this.ResumeDetailsUrl = match.Groups["DetailsUrl"].Value;
                }
            }
        }
        #endregion

        #region ParseCorporation
        /// <summary>
        /// 解析公司名称。
        /// </summary>
        protected virtual void ParseCorporation()
        {
            CompanyNameExpression regexpr = new CompanyNameExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["CompanyName"], null) && match.Groups["CompanyName"].Success)
                        this.CorporationName = match.Groups["CompanyName"].Value;
                }
            }
        }
        #endregion

        #region ParseGender
        /// <summary>
        /// 解析搜索结果中的性别。
        /// </summary>
        protected virtual void ParseGender()
        {
            GenderExpression regexpr = new GenderExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["Gender"], null) && match.Groups["Gender"].Success)
                        this.Gender = match.Groups["Gender"].Value;
                }
            }
        }
        #endregion

        #region ParseAge
        /// <summary>
        /// 解析搜索结果中的年龄。
        /// </summary>
        protected virtual void ParseAge()
        {
            AgeExpression regexpr = new AgeExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["Age"], null) && match.Groups["Age"].Success && !string.IsNullOrWhiteSpace(match.Groups["Age"].Value))
                        this.Age = int.Parse(match.Groups["Age"].Value);
                }
            }
        }
        #endregion

        #region ParseDegree
        /// <summary>
        /// 解析学历名称。
        /// </summary>
        protected virtual void ParseDegree()
        {
            DegreeExpression regexpr = new DegreeExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["Degree"], null) && match.Groups["Degree"].Success)
                    {
                        this.DegreeName = match.Groups["Degree"].Value;
                    }
                }
            }
        }
        #endregion

        #region ParseResidence
        /// <summary>
        /// 解析居住地址。
        /// </summary>
        protected virtual void ParseResidence()
        {
            ResidenceExpression regexpr = new ResidenceExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["Residence"], null) && match.Groups["Residence"].Success)
                        this.Residence = match.Groups["Residence"].Value;
                }
            }
        }
        #endregion

        #region ParseEducationalBackground
        /// <summary>
        /// 解析教育背景。
        /// </summary>
        protected virtual void ParseEducationalBackground()
        {
            EducationalBackgroundExpression regexpr = new EducationalBackgroundExpression();
            if (regexpr.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["EducationalBackground"], null) && match.Groups["EducationalBackground"].Success)
                        this.EducationalBackground = match.Groups["EducationalBackground"].Value;
                }
            }
        }
        #endregion

        #region ParseWorkingExperience
        /// <summary>
        /// 用于解析工作经历。
        /// </summary>
        protected virtual void ParseWorkingExperience()
        {
            WorkingExperienceExpression regexpr = new WorkingExperienceExpression();
            string serviceCycle = string.Empty;
            string corpration = string.Empty;
            string position = string.Empty;
            string salary = string.Empty;
            if (regexpr.IsMatch(this.SourceHtml))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["ServiceCycle"], null) && match.Groups["ServiceCycle"].Success)
                        serviceCycle = match.Groups["ServiceCycle"].Value.Trim().Replace("&nbsp;", string.Empty).Replace("|", string.Empty);
                    if (!object.ReferenceEquals(match.Groups["CompanyName"], null) && match.Groups["CompanyName"].Success)
                        corpration = match.Groups["CompanyName"].Value;
                    if (!object.ReferenceEquals(match.Groups["Position"], null) && match.Groups["Position"].Success)
                        position = match.Groups["Position"].Value;
                    if (!object.ReferenceEquals(match.Groups["Sarlary"], null) && match.Groups["Sarlary"].Success)
                        salary = match.Groups["Sarlary"].Value;
                }
                this.WorkingExperience = string.Format("公司：{0} | 职位：{1} | 工作年限：{2} | 薪资：{3}元/月", corpration, position, serviceCycle, salary);
            }
        }
        #endregion

        #region ParseResumeTags
        /// <summary>
        /// 解析简历标签。
        /// </summary>
        protected virtual void ParseResumeTags()
        {
            ResumeTagExpression exp1 = new ResumeTagExpression();
            ResumeTag2Expression exp2 = new ResumeTag2Expression();
            if (exp1.IsMatch(this.SourceHtml, RegexOptions.IgnoreCase))
            {
                string tags = exp1.Match(this.SourceHtml, RegexOptions.IgnoreCase).Value;
                if (!string.IsNullOrWhiteSpace(tags))
                {
                    MatchCollection matches = exp2.Matches(tags);
                    if (!object.ReferenceEquals(matches, null))
                    {
                        this.ResumeTags = new List<string>();
                        foreach (Match item in matches)
                        {
                            if (item.Success && !object.ReferenceEquals(item.Groups, null) && !object.ReferenceEquals(item.Groups["Tag"], null))
                            {
                                this.ResumeTags.Add(item.Groups["Tag"].Value);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region ParseUserPictureUrl
        /// <summary>
        /// 解析用户头像URL。
        /// </summary>
        protected virtual void ParseUserPictureUrl()
        {
            UserPictureExpression regexpr = new UserPictureExpression();
            if (regexpr.IsMatch(this.SourceHtml))
            {
                Match match = regexpr.Match(this.SourceHtml, RegexOptions.IgnoreCase);
                if (!object.ReferenceEquals(match.Groups, null) && match.Groups.Count > 0)
                {
                    if (!object.ReferenceEquals(match.Groups["PictureUrl"], null) && match.Groups["PictureUrl"].Success)
                        this.PictureUrl = match.Groups["PictureUrl"].Value;
                }
            }
        }
        #endregion

        #region Parse
        /// <summary>
        /// 执行解析。
        /// </summary>
        public virtual void Parse()
        {
            this.ParsePositionAndUrl();
            this.ParseCorporation();
            this.ParseAge();
            this.ParseDegree();
            this.ParseEducationalBackground();
            this.ParseGender();
            this.ParseResidence();
            this.ParseResumeTags();
            this.ParseUserPictureUrl();
            this.ParseWorkingExperience();
        }
        #endregion

        #region Split
        /// <summary>
        /// 按照指定的格式分割HTML搜索结果，以便解析片段。
        /// </summary>
        /// <param name="html">需要分割的HTML搜索结果。</param>
        /// <returns>字符串数组。</returns>
        static public string[] Split(string html)
        {
            return new SplitSearchResultExpression().Split(html, RegexOptions.IgnoreCase);
        }
        #endregion

        #region Parse
        /// <summary>
        /// 解析搜索结果HTML，获取结构化的搜索结果。
        /// </summary>
        /// <param name="html">搜索结果HTML文本内容。</param>
        /// <returns><see cref="SearchResultObject"/>对象实例集合。</returns>
        static public List<SearchResultObject> Parse(string html)
        {
            string[] input = SearchResultObject.Split(html);
            List<SearchResultObject> result = new List<SearchResultObject>();
            foreach (string item in input)
            {
                SearchResultObject obj = new SearchResultObject(item);
                if (obj.IsMatch)
                {
                    obj.Parse();
                    result.Add(obj);
                }
            }
            return result;
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