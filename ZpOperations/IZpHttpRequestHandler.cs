#region "IZpHttpRequestHandler"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-09-29 14:57:38
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn
 * 
 * ####     Type Name : IZpHttpRequestHandler
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.IZpHttpRequestHandler
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.IZpHttpRequestHandler</para>
    /// <para>
    /// 用于处理卓聘网HTTP请求的方法。
    /// </para>
    /// </summary>
    /// <typeparam name="TResult">返回结果类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IZpHttpRequestHandler<TResult>
    {
        #region RequestAndGetResponseData
        /// <summary>
        /// 发送请求，并获取相应数据。
        /// </summary>
        /// <param name="request"><see cref="IZpHttpRequest"/>对象实例。</param>
        /// <returns><typeparamref name="TResult"/>类型的响应数据。</returns>
        TResult RequestAndGetResponseData(IZpHttpRequest request);
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