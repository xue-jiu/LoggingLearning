using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemServices
{
    class Test2
    {
        private readonly ILogger<Test2> _logger;
        public Test2(ILogger<Test2> logger)
        {
            _logger = logger;
        }

        public void TwoTest()
        {
            _logger.LogDebug("开始连接数据库");
            _logger.LogDebug("连接数据库成功");
            _logger.LogWarning("查找数据失败,重试");
            _logger.LogWarning("查找数据失败,重试第二次");
            _logger.LogError("查找数据失败");


        }
    }
}
