#region "IndustryDataHelper"

/*
 * ####     Developer Name : Wang Yucai
 * 
 * ####     Development Tool : Microsoft VisualStudio 2010 Ultimate Edition
 * 
 * ####     Create Time : 2014-10-09 16:53:29
 * 
 * ####     Namespace : MasterDuner.HHProjects.Csq.Highpincn.Parameters
 * 
 * ####     Type Name : IndustryDataHelper
 * 
 * ####     Full Name : MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryDataHelper
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
    /// <para>MasterDuner.HHProjects.Csq.Highpincn.Parameters.IndustryDataHelper</para>
    /// <para>
    /// 获取行业数据的辅助方法类。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>Target Framework Version : 4.0</para>
    /// <para>此类不可继承。</para>
    /// </remarks>
    public sealed class IndustryDataHelper
    {
        private ClientSessionTag _sessionTag;

        #region SessionTag
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        public ClientSessionTag SessionTag
        {
            get { return _sessionTag; }
            set { _sessionTag = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// <para>构造函数：</para>
        /// <para>初始化一个<see cref="IndustryDataHelper" />对象实例。</para>
        /// </summary>
        public IndustryDataHelper()
        {
        }

        #endregion

        #region GetData
        /// <summary>
        /// 获取行业数据。
        /// </summary>
        /// <returns>行业数据集合。</returns>
        public IndustryCollection GetData()
        {
            IndustryCollection data = new IndustryCollection();
            data.InitializeThis();
            if (data.Count.Equals(0))
            {
                data = new IndustryHttpRequestHandler().RequestAndGetResponseData(new IndustryHttpRequest(this.SessionTag) { Method = HttpMethods.Get });
            }
            return data;
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