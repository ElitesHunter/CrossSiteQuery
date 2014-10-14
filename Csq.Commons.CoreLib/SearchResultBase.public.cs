#region "SearchResultBase"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 13:57:09
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : SearchResultBase
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.SearchResultBase
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.SearchResultBase</para>
    /// <para>
    /// 搜索结果基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    [DataContract]
    public class SearchResultBase
    {
        private bool _isSuccessful;
        private PerformStatus _status;
        private string _dataExpression;

        #region IsSuccessful
        /// <summary>
        /// 设置或获取搜索是否成功。
        /// </summary>
        [DataMember(IsRequired = true)]
        public virtual bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        #endregion

        #region Status
        /// <summary>
        /// 设置或获取执行状态代码。
        /// </summary>
        [DataMember]
        public virtual PerformStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region DataExpression
        /// <summary>
        /// 设置或获取搜索结果数据表达式。
        /// </summary>
        [DataMember]
        public virtual string DataExpression
        {
            get { return _dataExpression; }
            set { _dataExpression = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SearchResultBase" />对象实例。</para>
        /// </summary>
        public SearchResultBase()
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