#region "IRegExpression"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 14:47:46
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : IRegExpression
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.IRegExpression
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

using System.Collections.Generic;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.IRegExpression</para>
    /// <para>
    /// 正则表达式操作接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <typeparam name="TResult">正则表达式匹配结果类型。</typeparam>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IRegExpression<TResult>
    {
        #region GroupName
        /// <summary>
        /// 设置或获取正则表达式分组名称。
        /// </summary>
        string GroupName { get; set; }
        #endregion

        #region Expressions
        /// <summary>
        /// 获取正则表达式集合。
        /// </summary>
        IDictionary<string, string> Expressions { get; }
        #endregion

        #region InitExpressions
        /// <summary>
        /// 初始化正则表达式字典集合。
        /// </summary>
        void InitExpressions();
        #endregion

        #region Match
        /// <summary>
        /// 执行正则表达式匹配。
        /// </summary>
        /// <param name="text">需要匹配的正则表达式。</param>
        /// <returns>正则表达式匹配结果。</returns>
        TResult Match(string text);
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