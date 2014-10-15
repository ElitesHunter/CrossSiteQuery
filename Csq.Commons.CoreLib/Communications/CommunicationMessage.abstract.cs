#region "CommunicationMessage"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 10:09:22
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Communications
 * 
 * ####     Type Name : CommunicationMessage
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Communications.CommunicationMessage
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
using MasterDuner.Cooperations.Csq.Commons.Configuration;

namespace MasterDuner.Cooperations.Csq.Commons.Communications
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Communications.CommunicationMessage</para>
    /// <para>
    /// 与搜索通道进行通信的消息基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public abstract class CommunicationMessage
    {
        private string _contentType;
        private Guid _bindSessionID;
        private int _contentLength;
        private CommunicationMethods _method;

        #region ContentType
        /// <summary>
        /// 设置或获取通信内容的Content-Type字段。
        /// </summary>
        public virtual string ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }
        #endregion

        #region BindSessionID
        /// <summary>
        /// 设置或获取客户端与搜索服务绑定的会话标记。
        /// </summary>
        public virtual Guid BindSessionID
        {
            get { return _bindSessionID; }
            protected set { _bindSessionID = value; }
        }
        #endregion

        #region ContentLength
        /// <summary>
        /// 设置或获取HTTP通信信息的Content-Length字段。
        /// </summary>
        public virtual int ContentLength
        {
            get { return _contentLength; }
            set { _contentLength = value; }
        }
        #endregion

        #region GetChannel
        /// <summary>
        /// 获取当前的搜索渠道。
        /// </summary>
        /// <returns><see cref="SearchChannels"/>中的一个值。</returns>
        protected virtual SearchChannels GetChannel()
        {
            Type thisType = this.GetType();
            Attribute attr = Attribute.GetCustomAttribute(thisType, typeof(SearchChannelAttribute));
            if (object.ReferenceEquals(attr, null))
                return SearchChannels.Unknown;
            else
                return (attr as SearchChannelAttribute).Channel;
        }
        #endregion

        #region GetChannelConfig
        /// <summary>
        /// 获取搜索渠道的配置。
        /// </summary>
        /// <returns><see cref="SearchChannelElement"/>对象实例。</returns>
        protected virtual SearchChannelElement GetChannelConfig()
        {
            SearchChannels channel = this.GetChannel();
            if (channel.Equals(SearchChannels.Unknown)) throw new UnknownSearchChannelException();
            SearchChannelSection config = SearchChannelConfiguration.CurrentConfig.GetConfig();
            return config.Channels[(int)channel];
        }
        #endregion

        #region Method
        /// <summary>
        /// 设置或获取通信方法。
        /// </summary>
        public virtual CommunicationMethods Method
        {
            get { return _method; }
            set { _method = value; }
        }
        #endregion

        #region GetCommunicationMethodStr
        /// <summary>
        /// 获取通信方法字符串表达式。
        /// </summary>
        /// <returns>字符串表达式。</returns>
        protected virtual string GetCommunicationMethodStr()
        {
            string s = "GET";
            switch (this.Method)
            {
                case CommunicationMethods.HttpPost: s = "POST"; break;
                default: s = "GET"; break;
            }
            return s;
        }
        #endregion

        #region SendAndGet
        /// <summary>
        /// 发送并获取消息。
        /// </summary>
        /// <typeparam name="TMessage">消息类型。</typeparam>
        /// <returns><typeparamref name="TMessage"/>类型的消息。</returns>
        public abstract TMessage SendAndGet<TMessage>() where TMessage : CommunicationMessage;
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="CommunicationMessage" />对象实例。</para>
        /// </summary>
        /// <param name="sessionID">会话标记。</param>
        protected CommunicationMessage(Guid sessionID)
        {
            this.BindSessionID = sessionID;
            this.Method = CommunicationMethods.HttpGet;
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