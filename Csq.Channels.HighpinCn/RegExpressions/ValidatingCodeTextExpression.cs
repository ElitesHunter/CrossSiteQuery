#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 11:50:53
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


namespace MasterDuner.Cooperations.Csq.Channels.RegExpressions
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ValidatingCodeTextExpression"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Channels.RegExpressions"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 验证码文本匹配正则表达式。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class ValidatingCodeTextExpression : ExpressionBase
    {
        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ValidatingCodeTextExpression" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public ValidatingCodeTextExpression()
        { }

        #endregion

        #region Expression
        /// <summary>
        /// 获取正则表达式。
        /// </summary>
        protected override string Expression
        {
            get { return "[a-z0-9A-Z]{1,4}"; }
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