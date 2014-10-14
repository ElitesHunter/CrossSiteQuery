#region "IdBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 11:08:04
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : IdBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.IdBase
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.IdBase</para>
    /// <para>
    /// 搜索渠道内部定义的标识基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class IdBase
    {
        private string _innerId;

        #region InnerId
        /// <summary>
        /// 设置或获取搜索渠道内部定义的ID标识。
        /// </summary>
        [DataMember(IsRequired = true)]
        public virtual string InnerId
        {
            get { return _innerId; }
            set { _innerId = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="IdBase" />对象实例。</para>
        /// </summary>
        public IdBase()
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