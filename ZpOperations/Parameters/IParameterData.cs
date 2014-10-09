#region "IParameterData"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 15:04:18
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : IParameterData
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.IParameterData
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


namespace MasterDuner.HHProjects.Csq.Highpincn.Parameters
{
    /// <summary>
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.IParameterData</para>
    /// <para>
    /// 卓聘网参数数据接口。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// </remarks>
    public interface IParameterData
    {
        #region Key
        /// <summary>
        /// 设置或获取参数数据标识名称。
        /// </summary>
        string Key { get; set; }
        #endregion

        #region Value
        /// <summary>
        /// 设置或获取参数数据值。
        /// </summary>
        string Value { get; set; }
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