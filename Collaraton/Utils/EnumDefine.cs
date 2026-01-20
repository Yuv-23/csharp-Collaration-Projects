using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaraton.UI.Utils
{
    internal class EnumDefine
    {
        //任务状态枚举
        public enum TaskStatus
        {
            未开始 = 0,
            进行中 = 1,
            已提交 = 2,
            已审核 = 3,
            驳回 = 4
        }

        //用户角色枚举
        public enum UserRole
        {
            成员 = 0,
            项目经理 = 1,
            管理员 = 2
        }

        //项目状态枚举
        public enum ProjectStatus
        {
            未启动 = 0,
            进行中 = 1,
            已完成 = 2,
            已取消 = 3
        }
    }
}
