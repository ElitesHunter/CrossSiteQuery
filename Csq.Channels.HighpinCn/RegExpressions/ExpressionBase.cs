#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-23 10:25:10
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
using System.Text.RegularExpressions;

namespace MasterDuner.Cooperations.Csq.Channels.RegExpressions
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ExpressionBase"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.RegExpressions"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 正则表达式匹配基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    public abstract class ExpressionBase
    {
        #region Expression
        /// <summary>
        /// 获取正则表达式。
        /// </summary>
        protected abstract string Expression { get; }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ExpressionBase" />对象实例。
        /// </summary>
        protected ExpressionBase()
        { }

        #endregion

        #region IsMatch
        /// <summary>
        /// 文本内容是否与正则表达式匹配。
        /// </summary>
        /// <param name="s">需要匹配的文本内容。</param>
        /// <param name="options">匹配选项。</param>
        /// <returns><see cref="Boolean"/>值。</returns>
        public virtual bool IsMatch(string s, RegexOptions options = RegexOptions.None)
        {
            return Regex.IsMatch(s, this.Expression, options);
        }
        #endregion

        #region Match
        /// <summary>
        /// 从<paramref name="s"/>中获取匹配的项。
        /// </summary>
        /// <param name="s">文本。</param>
        /// <param name="options">匹配选项。</param>
        /// <returns><see cref="Match"/>对象实例。</returns>
        public virtual Match Match(string s, RegexOptions options = RegexOptions.None)
        {
            return Regex.Match(s, this.Expression, options);
        }
        #endregion

        #region Split
        /// <summary>
        /// 将字符串<paramref name="s"/>分割成字符串数组。
        /// </summary>
        /// <param name="s">需要分割的字符串。</param>
        /// <param name="options">匹配选项。</param>
        /// <returns>字符串数组。</returns>
        public virtual string[] Split(string s, RegexOptions options = RegexOptions.None)
        {
            return Regex.Split(s, this.Expression, options);
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