#region "BaseKeywords"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 10:04:06
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : BaseKeywords
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.BaseKeywords
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

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.BaseKeywords</para>
    /// <para>
    /// 搜索关键字基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class BaseKeywords : IKeywords
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseKeywords" />对象实例。</para>
        /// </summary>
        /// <param name="keywords">搜索关键字。</param>
        public BaseKeywords(string keywords)
        {
            this.Keywords = keywords;
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="BaseKeywords" />对象实例。</para>
        /// </summary>
        public BaseKeywords()
            : this(string.Empty)
        {
        }

        #endregion

        #region Keywords
        private string _keywords;
        /// <summary>
        /// 设置或获取关键字。
        /// </summary>
        public virtual string Keywords
        {
            get
            {
                return this._keywords;
            }
            set
            {
                this._keywords = value;
            }
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