#region "EducationalBackgroundBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:28:51
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : EducationalBackgroundBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.EducationalBackgroundBase
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.EducationalBackgroundBase</para>
    /// <para>
    /// 教育背景搜索条件基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class EducationalBackgroundBase
    {
        private DegreeBase _juniorDegree;
        private DegreeBase _seniorDegree;

        #region JuniorDegree
        /// <summary>
        /// 设置或获取最低学历要求。
        /// </summary>
        [DataMember]
        public virtual DegreeBase JuniorDegree
        {
            get { return _juniorDegree; }
            set { _juniorDegree = value; }
        }
        #endregion

        #region SeniorDegree
        /// <summary>
        /// 设置或获取最高学历要求。
        /// </summary>
        [DataMember]
        public virtual DegreeBase SeniorDegree
        {
            get { return _seniorDegree; }
            set { _seniorDegree = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="EducationalBackgroundBase" />对象实例。</para>
        /// </summary>
        public EducationalBackgroundBase()
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