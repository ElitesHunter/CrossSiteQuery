#region "SearchChannelAttribute"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-13 11:37:32
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : SearchChannelAttribute
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.SearchChannelAttribute
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
    /// <para>MasterDuner.Cooperations.Csq.Commons.SearchChannelAttribute</para>
    /// <para>
    /// 用于标记搜索渠道。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    [Serializable]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public sealed class SearchChannelAttribute : Attribute
    {
        private SearchChannels _channel;

        #region Channel
        /// <summary>
        /// 获取搜索渠道。
        /// </summary>
        public SearchChannels Channel
        {
            get { return _channel; }
            private set { _channel = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="SearchChannelAttribute" />对象实例。</para>
        /// </summary>
        /// <param name="channel">搜索渠道枚举类型。</param>
        public SearchChannelAttribute(SearchChannels channel)
        {
            this.Channel = channel;
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