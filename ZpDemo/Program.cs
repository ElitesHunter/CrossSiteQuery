using ZpDemo.WsReference;
using System;

namespace ZpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HighpinCnWsi wsi = new HighpinCnWsi())
            {
                //第一步，请求会话标记。
                ClientSessionTag sessionTag = wsi.RequestSessionTag();

                //请求卓聘网首页数据。此步WebService将初始化卓聘网的Cookie信息，以便尝试进行模拟登录。
                string hpHtml = wsi.PerformFirstStep(sessionTag);

                bool logonSuccess = false;
                while (!logonSuccess)
                {
                    //请求卓聘网的验证码。
                    string validatingCode = wsi.RequestValidatingCode(sessionTag);

                    //尝试登录卓聘网。
                    logonSuccess = wsi.TryLogon(sessionTag, validatingCode);
                }

                Console.WriteLine("成功登录卓聘网！");

                Console.Read();
            }
        }
    }
}
