#region "ZpUri"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 15:18:45
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ZpUri
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ZpUri
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
using MasterDuner.HHProjects.Csq.Highpincn.Configuration;

namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ZpUri</para>
    /// <para>
    /// 卓聘网URL对象。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class ZpUri : IZpUri
    {
        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpUri" />对象实例。</para>
        /// </summary>
        public ZpUri()
        {
        }

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ZpUri" />对象实例。</para>
        /// </summary>
        /// <param name="resourceName">此URL在配置文件中的名称。</param>
        public ZpUri(string resourceName)
            : this()
        {
            this._resName = resourceName;
            if (this._resName.Equals("HomePage"))
            {
                this.Url = ZpConfigurationManager.GetConfig().Resources.HomePage.Url;
            }
            else
            {
                this.Url = ZpConfigurationManager.GetConfig().Resources.UrlResources[this._resName].Url;
            }
        }

        #endregion

        #region ResourceName
        private string _resName;
        /// <summary>
        /// 获取此URL在配置文件中的名称。
        /// </summary>
        public virtual string ResourceName
        {
            get { return this._resName; }
        }
        #endregion

        #region Url
        private string _url;
        /// <summary>
        /// 设置或获取卓聘网的URL。
        /// </summary>
        public virtual string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
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