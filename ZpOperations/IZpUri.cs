#region "IZpUri"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-28 15:16:48
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : IZpUri
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.IZpUri
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.IZpUri</para>
    /// <para>
    /// 卓聘网URL接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IZpUri
    {
        #region ResourceName
        /// <summary>
        /// 获取此URL在配置文件中的标识名称。
        /// </summary>
        string ResourceName { get; }
        #endregion

        #region Url
        /// <summary>
        /// 设置或获取需要请求的URL。
        /// </summary>
        string Url { get; set; }
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