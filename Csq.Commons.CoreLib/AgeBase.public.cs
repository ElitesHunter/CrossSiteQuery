#region "AgeBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:15:13
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : AgeBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.AgeBase
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
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.AgeBase</para>
    /// <para>
    /// 年龄要求搜索条件基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class AgeBase
    {
        private int _upper;
        private int _lower;

        #region Upper
        /// <summary>
        /// 设置或获取年龄上限。
        /// </summary>
        [DataMember(IsRequired = false)]
        public virtual int Upper
        {
            get { return _upper; }
            set { _upper = value; }
        }
        #endregion

        #region Lower
        /// <summary>
        /// 设置或获取年龄下限。
        /// </summary>
        [DataMember(IsRequired = false)]
        public virtual int Lower
        {
            get { return _lower; }
            set { _lower = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="AgeBase" />对象实例。</para>
        /// </summary>
        public AgeBase()
        {
            this.Upper = -1;
            this.Lower = -1;
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