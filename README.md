# 项目协作平台（C# WinForms）
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-blue.svg)
![WinForms](https://img.shields.io/badge/UI-WinForms-brightgreen.svg)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server%202016+-orange.svg)
![iTextSharp](https://img.shields.io/badge/PDF-iTextSharp-purple.svg)

## 项目简介
本项目是 **C# WinForms 课程设计** 实现的团队任务协作管理桌面应用，专为高校课程设计场景和小型团队协作打造。
核心目标：解决小型团队任务分配混乱、进度跟踪滞后、文档散落丢失等问题，实现「任务全流程管控 + 文档集中管理 + 角色权限隔离 + 数据安全备份」的一体化协作方案。

## 技术栈
| 分类         | 技术/工具                          |
|--------------|------------------------------------|
| 开发框架     | .NET Framework 4.7.2+              |
| 前端界面     | Windows Forms (WinForms)           |
| 后端语言     | C#                                 |
| 数据库       | SQL Server 2016+                   |
| PDF 生成     | iTextSharp                         |
| 版本控制     | Git                                |
| 开发工具     | Visual Studio 2019/2022            |

## 核心功能
### 1. 角色权限管控（三级权限隔离）
| 角色       | 核心权限                                  | 数据访问范围                     |
|------------|-------------------------------------------|----------------------------------|
| 普通成员   | 查看个人任务、提交进度、上传附件、导出个人报告 | 仅 `ExecutorID = 个人ID` 的任务  |
| 项目经理   | 分配任务、审核进度、查看团队任务、管理附件    | 仅 `AllocatorID = 个人ID` 的项目/任务 |
| 系统管理员 | 用户管理、项目管理、数据备份、系统维护       | 全系统数据                       |

### 2. 任务全生命周期管理
- 任务状态流转：创建 → 分配 → 进行中 → 提交审核 → 完成/驳回
- 进度可视化：任务状态标签、进度条直观展示
- 历史记录：任务修改/进度更新日志追溯

### 3. 文档/附件管理
- 支持格式：
  - 图片：jpg/jpeg/png/bmp/gif
  - 文档：doc/docx/xls/xlsx/ppt/pptx/pdf/txt
- 附件关联：文件与任务/项目绑定，支持预览、下载、删除

### 4. 报表导出
- 个人任务完成情况 PDF 报告
- 团队项目进度汇总 PDF 报告

## 项目结构
<details>
  <summary>📁 点击展开/收起完整项目结构</summary>
csharp-Collaration-Projects/  # 项目根目录
├── ProjectCollabPlatform.sln          # 解决方案文件（VS入口）
├── ProjectCollabPlatform/             # 主WinForms项目目录
│   ├── Forms/                         # 窗体层（按角色拆分UI）
│   │   ├── LoginForm.cs               # 登录窗体（权限校验入口）
│   │   ├── MainForm.cs                # 主窗体基类（通用布局/方法）
│   │   ├── AdminForm.cs               # 管理员专属操作界面
│   │   ├── ManagerForm.cs             # 项目经理功能界面
│   │   └── MemberForm.cs              # 普通成员操作界面
│   ├── Models/                        # 数据模型层（ORM映射）
│   │   ├── User.cs                    # 用户实体（角色/账号信息）
│   │   ├── Project.cs                 # 项目实体（名称/负责人/周期）
│   │   └── Task.cs                    # 任务实体（状态/进度/附件关联）
│   ├── Services/                      # 业务逻辑层（解耦UI与数据）
│   │   ├── TaskService.cs             # 任务增删改查/进度更新逻辑
│   │   ├── ProjectService.cs          # 项目创建/编辑/删除逻辑
│   │   └── AuthService.cs             # 登录验证/权限判断逻辑
│   ├── Utilities/                     # 通用工具类（复用功能）
│   │   ├── DBHelper.cs                # 数据库连接/CRUD封装
│   │   ├── PdfExporter.cs             # PDF报告生成工具（iTextSharp）
│   │   └── FileValidator.cs           # 附件格式/大小校验工具
│   ├── Resources/                     # 静态资源目录
│   │   ├── Images/                    # 界面图片（背景/Logo）
│   │   └── Icons/                     # 功能图标（按钮/状态标识）
│   └── App.config                     # 配置文件（数据库连接串等）
├── DatabaseScripts/                   # 数据库脚本目录（一键部署）
│   ├── CreateTables.sql               # 表结构创建语句（Users/Projects/Tasks）
│   └── SampleData.sql                 # 测试数据（课设演示用）
└── README.md                          # 项目说明文档
</details>

## 快速开始（课程设计部署）
### 环境要求
1. 安装 Visual Studio 2019/2022（需安装 .NET Framework 4.7.2 开发工具）
2. 安装 SQL Server 2016+（或 SQL Server Express 免费版）

### 部署步骤
1. 克隆本仓库：`git clone https://github.com/Yuv-23/csharp-Collaration-Projects.git`
2. 执行数据库脚本：
   - 打开 SQL Server Management Studio (SSMS)
   - 执行 `DatabaseScripts/CreateTables.sql` 创建表结构
   - （可选）执行 `DatabaseScripts/SampleData.sql` 导入测试数据
3. 配置数据库连接：
   - 打开 `ProjectCollabPlatform/App.config`
   - 修改 `<connectionStrings>` 中的 `server`/`user id`/`password` 为你的 SQL Server 信息
4. 运行项目：
   - 用 Visual Studio 打开 `ProjectCollabPlatform.sln`
   - 右键解决方案 → 还原 NuGet 包（自动安装 iTextSharp 等依赖）
   - 按 F5 启动调试

## 未来扩展方向
### 功能增强
1. 即时通信模块：团队内消息推送/聊天
2. 移动端适配：基于 MAUI 开发跨平台移动端
3. 智能分析：任务进度预警、团队效率统计报表

### 技术升级
1. 架构重构：采用三层架构（UI → BLL → DAL）+ 依赖注入
2. 数据库优化：引入 EF Core 替代原生 ADO.NET
3. 部署优化：打包为 EXE 安装包，支持一键部署

## 致谢
如果本项目对你的 C# 课程设计有帮助，欢迎点亮 ⭐ Star 支持！

### 联系方式
- 邮箱：vickyyyxpan@outlook.com
- GitHub：[@Yuv-23](https://github.com/Yuv-23)
  
