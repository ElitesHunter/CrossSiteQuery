#region "ZpCookie"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 14:50:32
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpCookie
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpCookie
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

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpCookie</para>
    /// <para>
    /// 卓聘网Cookie对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    [Serializable]
    public sealed class ZpCookie : IZpCookie
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpCookie" />对象实例。</para>
        /// </summary>
        public ZpCookie()
        {
        }

        #endregion

        #region Name
        private string _name;
        /// <summary>
        /// 设置或获取Cookie名称。
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        #endregion

        #region Value
        private string _value;
        /// <summary>
        /// 设置或获取Cookie值。
        /// </summary>
        public string Value
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