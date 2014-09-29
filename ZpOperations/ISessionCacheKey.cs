#region "ISessionCacheKey"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 10:32:07
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : ISessionCacheKey
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.ISessionCacheKey
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


namespace MasterDuner.HHProjects.Csq.Highpincn
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.ISessionCacheKey</para>
    /// <para>
    /// 与会话绑定的缓存键。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ISessionCacheKey
    {
        #region SessionTag
        /// <summary>
        /// 获取会话标记。
        /// </summary>
        ISessionTag SessionTag { get; }
        #endregion

        #region GetCacheKey
        /// <summary>
        /// 获取缓存数据的键名称。
        /// </summary>
        /// <param name="category"><see cref="SessionCacheCategory"/>中的一个值。</param>
        /// <returns>缓存键名称。</returns>
        string GetCacheKey(SessionCacheCategory category);
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