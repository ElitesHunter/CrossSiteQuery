#region "ParameterData"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 15:06:47
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : ParameterData
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.ParameterData
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

namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.ParameterData</para>
    /// <para>
    /// 卓聘网参数数据基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public abstract class ParameterData : IParameterData
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ParameterData" />对象实例。</para>
        /// </summary>
        protected ParameterData()
        {
        }

        #endregion

        #region Key
        private string _key;
        /// <summary>
        /// 设置或获取参数数据标识名称。
        /// </summary>
        public virtual string Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        #endregion

        #region Value
        private string _value;
        /// <summary>
        /// 设置或获取参数数据值。
        /// </summary>
        public virtual string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
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