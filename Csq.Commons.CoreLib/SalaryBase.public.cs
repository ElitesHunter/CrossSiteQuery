#region "SalaryBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:34:00
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : SalaryBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.SalaryBase
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.SalaryBase</para>
    /// <para>
    /// 薪资要求搜索条件基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class SalaryBase
    {
        private decimal _min;
        private decimal _max;

        #region Min
        /// <summary>
        /// 设置或获取最低薪资要求。
        /// </summary>
        [DataMember]
        public virtual decimal Min
        {
            get { return _min; }
            set { _min = value; }
        }
        #endregion

        #region Max
        /// <summary>
        /// 设置或获取最高薪资要求。
        /// </summary>
        [DataMember]
        public virtual decimal Max
        {
            get { return _max; }
            set { _max = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SalaryBase" />对象实例。</para>
        /// </summary>
        public SalaryBase()
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