#region "DateTimeExtensions"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-08 16:30:05
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : DateTimeExtensions
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.DateTimeExtensions
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.DateTimeExtensions</para>
    /// <para>
    /// 对<see cref="DateTime"/>类型提供的扩展方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public static class DateTimeExtensions
    {
        #region GetTimeJavaScript
        /// <summary>
        /// 兼容JavaScript中的getTime方法。
        /// </summary>
        /// <param name="time"></param>
        /// <returns>长整型值。</returns>
        static public long GetTimeJavaScript(this DateTime time)
        {
            long value = 621355968000000000L;
            return (time.ToUniversalTime().Ticks - value) / 10000000;
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