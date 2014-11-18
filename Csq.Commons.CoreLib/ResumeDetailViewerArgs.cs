#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-11-18 9:52:52
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
    /// 类型名称：<see cref="ResumeDetailViewerArgs"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.Commons"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 用于查看简历详细信息的参数集。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    [Serializable]
    [DataContract]
    public class ResumeDetailViewerArgs
    {
        private string _detailPageUrl;

        #region DetailPageUrl
        /// <summary>
        /// 设置或获取简历详情页的URL地址。
        /// </summary>
        public virtual string DetailPageUrl
        {
            get { return _detailPageUrl;}
            set { _detailPageUrl = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="ResumeDetailViewerArgs" />对象实例。
        /// </summary>
        public ResumeDetailViewerArgs()
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