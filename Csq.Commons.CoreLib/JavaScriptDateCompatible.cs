#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-21 10:34:47
 * 
 * Machine Name : GLCHQWYCWINW7
 * 
 * Current User : GUOCOLAND/wangyucai
 * 
 * CLR Version : 4.0.30319.18444
 * 
 * Target Framework : This type is available for 4.0 and above versions of .NET Framework.
 */

#endregion

using System;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="JavaScriptDateCompatible"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Commons"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// JavaScript Date数据类型兼容性操作。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    public static class JavaScriptDateCompatible
    {
        private const long StandardValue = 621355968000000000L;

        #region GetTimeTicks
        /// <summary>
        /// 获取JavaScript兼容的时间长整型值。
        /// </summary>
        /// <param name="time"><see cref="DateTime"/>类型值。</param>
        /// <returns><see cref="Int64"/>类型值。</returns>
        static public long GetTimeTicks(DateTime time)
        {
            return (time.ToUniversalTime().Ticks - JavaScriptDateCompatible.StandardValue) / 10000000;
        }
        #endregion
    }
}

#region Contact me

/*
 * E-mail Address : Masterduner@Yeah.net or Yucai.Wang-Public@Outlook.com
 * 
 * Mobile : +86 13621384677
 * 
 * QQ : 180261899
 */

#endregion

/* Copyright © 2014 Wang Yucai. All rights reserved. */