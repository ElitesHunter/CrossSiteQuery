using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZpDemo.WsReference;

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

                //请求卓聘网的验证码。
                string validatingCode = wsi.RequestValidatingCode(sessionTag);
            }
        }
    }
}
