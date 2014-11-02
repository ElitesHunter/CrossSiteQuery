#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-27 11:06:37
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
using System.Diagnostics;
using System.IO;
using System.Text;
using MasterDuner.Cooperations.Csq.TestProjects.ResumeSearchService;

namespace MasterDuner.Cooperations.Csq.TestProjects
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="HighpinCn"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="MasterDuner.Cooperations.Csq.TestProjects"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class HighpinCn
    {
        private Guid _sessionID;
        private bool _isAuthenticated;

        #region SessionID
        /// <summary>
        /// 设置或获取会话标记。
        /// </summary>
        public Guid SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; }
        }
        #endregion

        #region IsAuthenticated
        /// <summary>
        /// <para>
        /// 设置或获取是否已经登录。
        /// </para>
        /// <para>
        /// 在WEB应用中可以通过Cookie等方式进行验证。
        /// </para>
        /// </summary>
        private bool IsAuthenticated
        {
            get { return _isAuthenticated; }
            set { _isAuthenticated = value; }
        }
        #endregion

        #region CreateSession
        /// <summary>
        /// 创建与搜索服务间的会话标记。
        /// </summary>
        private void CreateSession()
        {
            Trace.Write("创建与搜索服务间的会话标记。");
            using (SearchChannelService service = new SearchChannelService())
            {
                //在WEB应用中可以将此会话标记保存到Cookie或者Session中。
                this.SessionID = service.CreateSession();
                Trace.Write(string.Format("会话标记：{0}", this.SessionID));
            }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="HighpinCn" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public HighpinCn()
        {
            Trace.Write("智联卓聘网www.highpin.cn");
            this.CreateSession();
            this.IsAuthenticated = false;
        }

        #endregion

        #region TrySearchResumes
        /// <summary>
        /// 尝试搜索简历。
        /// </summary>
        public void TrySearchResumes()
        {
            if (!this.IsAuthenticated)
            {
                Trace.Write("没有登录，请输入用户名密码后登录到卓聘网！");
                Console.Write("Enter your user-name : ");
                string userName = Console.ReadLine();
                Console.Write("Enter your password : ");
                string password = Console.ReadLine();
                this.Authenticate(userName, password);
            }

            Trace.Write("尝试进行简历搜索。");
            using (SearchChannelService service = new SearchChannelService())
            {
                string html = service.Search(this.SessionID, this.CreateSearchParameter(), new ResultPage() { Index = 1, Size = 30 }).DataExpression;
                this.SaveHtmlResultToDisk(html);
            }
            Trace.Write("搜索完毕！");
        }
        #endregion

        #region Authenticate
        /// <summary>
        /// 执行身份认证。
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        private void Authenticate(string userName, string password)
        {
            using (SearchChannelService service = new SearchChannelService())
            {
                AuthenticationResult result = service.Login(new HPCredentials() { UserName = userName, Password = password }, this.SessionID);
            }
        }
        #endregion

        #region CreateSearchParameter
        /// <summary>
        /// 创建智联卓聘网的搜索参数。
        /// </summary>
        /// <returns></returns>
        private HPRequirement CreateSearchParameter()
        {
            return new HPRequirement()
            {
                Gender = Gender.All,
                Private = new HPExpandoRequirementObject()
                {
                    Corporation = "百度",
                    Lastest = false,
                    OverseasWorkingExperienceRequired = OverseasWorkingExperienceRequired.All,
                    ProfessionName = "计算机",
                    WorkingStatus = WorkingStatus.Left
                }
            };
        }
        #endregion

        #region SaveHtmlResultToDisk
        /// <summary>
        /// 保存HTML到硬盘中。
        /// </summary>
        /// <param name="html"></param>
        private void SaveHtmlResultToDisk(string html)
        {
            FileInfo file = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"{0}-{1}.htm", Guid.NewGuid(), DateTime.Now.Ticks)));
            byte[] bytes = Encoding.UTF8.GetBytes(html);
            using (FileStream stream = new FileStream(file.FullName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                try
                {
                    Trace.Write(string.Format("尝试将搜索结果保存到文件{0}中！", file.FullName));
                    stream.Write(bytes, 0, bytes.Length);
                    Trace.Write("写入完毕");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    stream.Close();
                }
            }
        }
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