#region "ParameterDataCollection"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 15:14:18
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : ParameterDataCollection
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.ParameterDataCollection
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
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Caching;

namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.ParameterDataCollection</para>
    /// <para>
    /// <see cref="ParameterData"/>集合。
    /// </para>
    /// </summary>
    /// <typeparam name="T">继承自<see cref="ParameterData"/>的类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    [Serializable]
    public class ParameterDataCollection<T> : List<T>
        where T : ParameterData
    {
        #region CacheKey
        /// <summary>
        /// 获取缓存数据的标识名称。
        /// </summary>
        protected virtual string CacheKey
        {
            get { return string.Empty; }
        }
        #endregion

        #region InitializeThis
        /// <summary>
        /// 初始化此集合。
        /// </summary>
        public virtual void InitializeThis()
        {
            ParameterDataCollection<T> data = this.GetFromCache();
            if (!object.ReferenceEquals(data, null))
            {
                foreach (T item in data) this.Add(item);
            }
        }
        #endregion

        #region SaveInCache
        /// <summary>
        /// 将此集合保存到缓存中。
        /// </summary>
        protected virtual void SaveInCache()
        {
            HttpRuntime.Cache.Insert(
                    this.CacheKey,
                    this,
                    new CacheDependency(Path.Combine(HttpRuntime.AppDomainAppPath, "web.config")),
                    DateTime.Now.AddHours(12),
                    Cache.NoSlidingExpiration
                );
        }
        #endregion

        #region GetFromCache
        /// <summary>
        /// 从缓存中获取此集合。
        /// </summary>
        /// <returns>参数数据集合。</returns>
        protected virtual ParameterDataCollection<T> GetFromCache()
        {
            object data = HttpRuntime.Cache[this.CacheKey];
            return object.ReferenceEquals(data, null) ? null : data as ParameterDataCollection<T>;
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="ParameterDataCollection" />对象实例。</para>
        /// </summary>
        public ParameterDataCollection()
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