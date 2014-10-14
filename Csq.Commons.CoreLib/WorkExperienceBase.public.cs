#region "WorkExperienceBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:19:32
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : WorkExperienceBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.WorkExperienceBase
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.WorkExperienceBase</para>
    /// <para>
    /// 工作经验搜索条件基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class WorkExperienceBase
    {
        private int _upper;
        private int _lower;

        #region Upper
        /// <summary>
        /// 设置或获取工作经验上限。
        /// </summary>
        [DataMember]
        public virtual int Upper
        {
            get { return _upper; }
            set { _upper = value; }
        }
        #endregion

        #region Lower
        /// <summary>
        /// 设置或获取工作经验下限。
        /// </summary>
        [DataMember]
        public virtual int Lower
        {
            get { return _lower; }
            set { _lower = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="WorkExperienceBase" />对象实例。</para>
        /// </summary>
        public WorkExperienceBase()
        {
            this.Upper = this.Lower = -1;
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