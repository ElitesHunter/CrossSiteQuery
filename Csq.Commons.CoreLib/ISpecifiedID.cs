#region "ISpecifiedID"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-14 9:57:57
 * 
 * ####     Namespace : MasterDuner.Cooperations.Csq.Commons
 * 
 * ####     Type Name : ISpecifiedID
 * 
 * ####     Full Name : MasterDuner.Cooperations.Csq.Commons.ISpecifiedID
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


namespace MasterDuner.Cooperations.Csq.Commons
{
    /// <summary>
    /// <para>MasterDuner.Cooperations.Csq.Commons.ISpecifiedID</para>
    /// <para>
    /// 搜索渠道设定的标识名称接口。
    /// </para>
    /// </summary>
    /// <typeparam name="T">指定标识类型。</typeparam>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface ISpecifiedID<T>
    {
        #region UniqueID
        /// <summary>
        /// 设置或获取搜索渠道指定的标识名称。
        /// </summary>
        T UniqueID { get; set; }
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