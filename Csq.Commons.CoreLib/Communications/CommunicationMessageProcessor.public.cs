#region "CommunicationMessageProcessor"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-16 10:40:07
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Communications
 * 
 * ####     Type Name : CommunicationMessageProcessor
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Communications.CommunicationMessageProcessor
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


namespace MasterDuner.Cooperations.Csq.Commons.Communications
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Communications.CommunicationMessageProcessor</para>
    /// <para>
    /// 处理通信消息的基类。
    /// </para>
    /// </summary>
    /// <typeparam name="TRequest">HTTP请求消息类型。</typeparam>
    /// <typeparam name="TResponse">HTTP响应消息基类。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class CommunicationMessageProcessor<TRequest, TResponse>
        where TRequest : HttpWebRequestMessage
        where TResponse : HttpWebResponseMessage
    {
        private TRequest _request;

        #region Request
        /// <summary>
        /// 设置或获取请求对象实例。
        /// </summary>
        protected virtual TRequest Request
        {
            get { return _request; }
            set { _request = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="CommunicationMessageProcessor{TRequest,TResponse}" />对象实例。</para>
        /// </summary>
        /// <param name="request"><typeparamref name="TRequest"/>类型的请求对象实例。</param>
        public CommunicationMessageProcessor(TRequest request)
        {
            this.Request = request;
        }

        #endregion

        #region SendAndGet
        /// <summary>
        /// 发送请求并获取相应。
        /// </summary>
        /// <returns><typeparamref name="TResponse"/>类型的响应消息。</returns>
        public virtual TResponse SendAndGet()
        {
            return this.Request.SendAndGet<TResponse>();
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