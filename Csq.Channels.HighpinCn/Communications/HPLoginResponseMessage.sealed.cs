#region "HPLoginResponseMessage"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-16 11:14:03
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Channels.Communications
 * 
 * ####     Type Name : HPLoginResponseMessage
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Channels.Communications.HPLoginResponseMessage
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
using MasterDuner.Cooperations.Csq.Commons.Communications;
using MasterDuner.Cooperations.Csq.Commons;
using System.Net;

namespace MasterDuner.Cooperations.Csq.Channels.Communications
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Channels.Communications.HPLoginResponseMessage</para>
    /// <para>
    /// 智联卓聘网登录相应消息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    [SearchChannel(SearchChannels.HighpinCn)]
    public sealed class HPLoginResponseMessage : HttpWebResponseMessage
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="HPLoginResponseMessage" />对象实例。</para>
        /// </summary>
        public HPLoginResponseMessage(Guid sessionID, HttpWebResponse response)
            : base(sessionID, response)
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