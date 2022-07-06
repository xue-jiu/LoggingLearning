using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLearning
{
    public class Test
    {
        private readonly ILogger<Test> _logger;
        public Test(ILogger<Test> logger)
        {
            _logger = logger;
        }
        public void OneTest() 
        {
            _logger.LogDebug("开始连接数据库");
            _logger.LogDebug("连接数据库成功");
            _logger.LogWarning("查找数据失败,重试");
            _logger.LogWarning("查找数据失败,重试第二次");
            _logger.LogError("查找数据失败");
            try
            {
                File.ReadAllText(@"D:\desktop\数据库使用1.txt");
                _logger.LogError("读取文件成功");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"读取文件失败");
            }

        }


    }
}
