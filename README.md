# 项目协作平台课设
c#课程设计；C# Winforms task management system for university course design.
## 项目概述
项目协作平台是一个基于C# WinForms开发的桌面应用程序，专为小型团队设计。本系统通过数字化工具解决任务分配混乱、进度跟踪滞后、文档散落丢失等团队协作常见痛点，实现了任务全流程管控、文档集中管理、角色权限隔离和项目数据安全备份。

## 系统架构
###技术栈
**开发平台**  .NET Framework 4.7.2+
**前端框架**  Windows Forms (WinForms)
**后端语言**  C#
**数据库**    SQL Server 2016+
**报表生成**  	iTextSharp
**版本控制**  	Git
###数据库
用户(Users) ──┬── 创建 ──▶ 项目(Projects)
              ├── 执行 ──▶ 任务(Tasks) ─── 属于 ──▶ 项目(Projects)
              └── 分配 ──▶ 任务(Tasks)
              
## 核心功能详解
###1. 用户角色与权限
| 角色 | 核心权限 | 数据范围 |
|** 成员 **| 查看个人任务、提交进度、上传文档/截图、导出个人报告|'ExecutorID'=自己的任务|
|** 项目经理 **| 分配任务、审核进度、查看团队任务、查看附件 |'AllocatorID'=自己的任务|
|** 管理员 **| 项目管理、用户管理、数据备份、系统维护 |全系统数据|
###2. 任务状态流转
###3. 文件关联管理
支持格式：
  - 截图：.jpg, .jpeg, .png, .bmp, .gif
  - 文档：.doc, .docx, .xls, .xlsx, .ppt, .pptx, .pdf, .txt
###4. PDF报告生成
  - 个人任务报告
  - 团队进度报告

## 项目结构
csharp-Collaration-Projects/
├── ProjectCollabPlatform.sln              # 解决方案文件
├── ProjectCollabPlatform/                 # 主项目
│   ├── Forms/                             # 窗体文件
│   │   ├── LoginForm.cs                   # 登录窗体
│   │   ├── MainForm.cs                    # 主窗体基类
│   │   ├── AdminForm.cs                   # 管理员界面
│   │   ├── ManagerForm.cs                 # 项目经理界面
│   │   └── MemberForm.cs                  # 成员界面
│   ├── Models/                            # 数据模型
│   │   ├── User.cs
│   │   ├── Project.cs
│   │   └── Task.cs
│   ├── Services/                          # 业务服务
│   │   ├── TaskService.cs
│   │   ├── ProjectService.cs
│   │   └── AuthService.cs
│   ├── Utilities/                         # 工具类
│   │   ├── DBHelper.cs                    # 数据库助手
│   │   ├── PdfExporter.cs                 # PDF导出工具
│   │   └── FileValidator.cs               # 文件验证工具
│   ├── Resources/                         # 资源文件
│   │   ├── Images/                        # 图片资源
│   │   └── Icons/                         # 图标资源
│   └── App.config                         # 配置文件
├── DatabaseScripts/                       # 数据库脚本
│   ├── CreateTables.sql                   # 建表语句
│   └── SampleData.sql                     # 示例数据
└── README.md                              # 项目说明

## 未来扩展方向
###功能增强
1. 即时通信模块
2. 移动端适配
3. 智能分析：任务进度评估、团队效率分析
   
###技术升级
1. 架构升级
2. 部署优化

## ⭐ 如果这个项目对你有帮助，请点个Star支持一下！
 - **邮箱**：vickyyyxpan@outlook.com
 - **GitHub**：@Yuv-23
   
