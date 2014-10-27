#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 15:48:28
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
using System.Runtime.Serialization;

namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ResultPage"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Commons"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 搜索结果页码信息。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public class ResultPage
    {
        private int _size = 20;
        private int _index = 1;

        #region Size
        /// <summary>
        /// 设置或获取每页结果的个数。
        /// </summary>
        [DataMember]
        public virtual int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        #endregion

        #region Index
        /// <summary>
        /// 设置或获取页索引。
        /// </summary>
        [DataMember]
        public virtual int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResultPage" />对象实例。
        /// </summary>
        public ResultPage()
        { }

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