#region "IndustryCollection"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 15:20:34
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : IndustryCollection
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryCollection
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
using System.Text.RegularExpressions;
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryCollection</para>
    /// <para>
    /// 行业参数数据集合。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class IndustryCollection : ParameterDataCollection<Industry>, IRegExpression<IndustryCollection>
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="IndustryCollection" />对象实例。</para>
        /// </summary>
        public IndustryCollection()
        {
            this._exprDic = new Dictionary<string, string>();
            this.GroupName = "Industry";
        }

        #endregion

        #region GroupName
        private string _regexGroup;
        /// <summary>
        /// 设置或获取正则表达式分组名称。
        /// </summary>
        public virtual string GroupName
        {
            get
            {
                return this._regexGroup;
            }
            set
            {
                this._regexGroup = value;
            }
        }
        #endregion

        #region Expressions
        private Dictionary<string, string> _exprDic;
        /// <summary>
        /// 获取正则表达式字典。
        /// </summary>
        public virtual IDictionary<string, string> Expressions
        {
            get { return this._exprDic; }
        }
        #endregion

        #region InitExpressions
        /// <summary>
        /// 初始化正则表达式字典集合。
        /// </summary>
        public virtual void InitExpressions()
        {
            RegExpressionGroupElement group = ZpConfigurationManager.GetConfig().TextParser.RegularExpressions[this.GroupName];
            foreach (RegExpressionElement item in group.Expressions)
            {
                this.Expressions.Add(item.Name, item.Expression);
            }
        }
        #endregion

        #region Match
        /// <summary>
        /// 执行正则表达式匹配。
        /// </summary>
        /// <param name="text">需要匹配的文本。</param>
        /// <returns><see cref="IndustryCollection"/>对象实例。</returns>
        public virtual IndustryCollection Match(string text)
        {
            IndustryCollection result = new IndustryCollection();
            MatchCollection primaryMatches = this.PerformPrimaryMatches(text);
            foreach (Match item in primaryMatches)
            {
                Industry instance = this.MatchAndGetInstance(item);
                if (!object.ReferenceEquals(instance, null)) result.Add(instance);
            }
            result.SaveInCache();
            return result;
        }
        #endregion

        #region PerformPrimaryMatches
        /// <summary>
        /// 执行第一次主要匹配。
        /// </summary>
        /// <param name="text">需要匹配的文本。</param>
        /// <returns>匹配项集合。</returns>
        protected virtual MatchCollection PerformPrimaryMatches(string text)
        {
            return Regex.Matches(text, this.Expressions["Primary"]);
        }
        #endregion

        #region MatchAndGetInstance
        /// <summary>
        /// 继续执行匹配，并获取相应的行业对象实例。
        /// </summary>
        /// <param name="match">匹配项。</param>
        /// <returns><see cref="Industry"/>对象实例。</returns>
        protected virtual Industry MatchAndGetInstance(Match match)
        {
            if (match.Success)
            {
                Match id = Regex.Match(match.Value, this.Expressions["IndustryID"]);
                Match name = Regex.Match(match.Value, this.Expressions["IndustryName"]);
                if (id.Success && !string.IsNullOrWhiteSpace(id.Value) && name.Success && !string.IsNullOrWhiteSpace(name.Value))
                {
                    return new Industry() { Key = id.Value.Replace("[", string.Empty).Replace("]", string.Empty), Value = name.Value };
                }
            }
            return null;
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