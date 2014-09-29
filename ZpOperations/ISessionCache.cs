#region "ISessionCache"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:36:14
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ISessionCache
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ISessionCache
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ISessionCache</para>
    /// <para>
    /// 会话级缓存数据接口。
    /// </para>
    /// </summary>
    /// <typeparam name="T">需要缓存的数据类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ISessionCache<T>
    {
        #region GetCacheData
        /// <summary>
        /// 获取缓存数据。
        /// </summary>
        /// <param name="key">缓存数据的键名称。</param>
        /// <returns><typeparamref name="T"/>类型的数据。</returns>
        T GetCacheData(string key);
        #endregion

        #region UpdateCacheData
        /// <summary>
        /// 更新缓存数据。
        /// </summary>
        /// <param name="key">缓存数据的键名称。</param>
        /// <param name="data"><typeparamref name="T"/>类型的缓存数据。</param>
        void UpdateCacheData(string key, T data);
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