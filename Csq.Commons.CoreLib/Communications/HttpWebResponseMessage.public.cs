#region "HttpWebResponseMessage"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-15 10:50:10
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons.Communications
 * 
 * ####     Type Name : HttpWebResponseMessage
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.Communications.HttpWebResponseMessage
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
using System.Net;

namespace MasterDuner.Cooperations.Csq.Commons.Communications
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.Communications.HttpWebResponseMessage</para>
    /// <para>
    /// HTTP相应的消息基类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public class HttpWebResponseMessage : CommunicationMessage
    {
        private HttpWebResponse _response;

        #region Response
        /// <summary>
        /// 设置或获取相应对象。
        /// </summary>
        protected virtual HttpWebResponse Response
        {
            get { return _response; }
            set { _response = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="HttpWebResponseMessage" />对象实例。</para>
        /// </summary>
        public HttpWebResponseMessage()
        {
        }

        #endregion

        #region SendAndGet
        /// <summary>
        /// 尚未实现此方法。
        /// </summary>
        /// <typeparam name="TMessage">消息类型。</typeparam>
        /// <returns><typeparamref name="TMessage"/>类型的消息。</returns>
        public override TMessage SendAndGet<TMessage>()
        {
            throw new NotImplementedException();
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