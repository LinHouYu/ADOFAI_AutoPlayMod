# ADOFAI AutoPlay Mod (冰与火之舞 全自动游玩插件)

这是一个基于 BepInEx 5 框架为《冰与火之舞》(A Dance of Fire and Ice) 制作的自动化游玩插件。
它可以强制开启游戏内置的自动游玩变量，让你无需按键即可 100% 完美通关任何官方关卡与高难度自制谱！

## 核心功能 (What it does)

- **无缝全自动**：进入任何关卡（含自制谱），游戏会自动接管按键，全程完美判定。
- **底层安全注入**：通过 Harmony 劫持 `scrController.Awake`，动态修改 `RDC.auto = true`，**不破坏任何游戏原始文件**。
- **即插即用**：想自己手打时，只需将插件移出文件夹即可，非常方便。

---

## 安装与使用教程 (How to use)

### 第一步：安装前置框架 (BepInEx 5)
如果你的游戏还没有安装 BepInEx 框架，请先按照以下步骤操作（如果已安装请跳过）：
1. 下载 **[BepInEx 5 (x64)](https://github.com/BepInEx/BepInEx/releases)**（注意：请使用 5.x 版本，不要使用 6.0 预览版）。
2. 解压下载的 `.zip` 压缩包。
3. 将解压出来的所有内容（必须包含 `BepInEx` 文件夹、`doorstop_config.ini` 和 `winhttp.dll`）全部拖入游戏的根目录中。
   - *游戏根目录通常为：`Steam\steamapps\common\A Dance of Fire and Ice\`*
4. **启动一次游戏，到达主界面后退出**。这一步是为了让 BepInEx 初始化并自动生成 `plugins` 文件夹。

### 第二步：安装本插件
1. 在本仓库的 [Releases] 页面下载最新版的 `ADOFAI_AutoPlayMod.dll`（或者你自己编译生成的 DLL）。
2. 将该 DLL 文件放入游戏目录下的插件文件夹中：
   👉 `游戏根目录/BepInEx/plugins/`
3. 重新启动游戏，进入任意关卡，松开双手，享受神仙般的全自动游玩吧！

---

## 注意事项

- 本插件仅供学习交流与观赏变态自制谱使用，请勿用于破坏游戏平衡或刷取排行榜成绩。
- 只有在游戏未运行时，才能添加或删除 `plugins` 文件夹里的 DLL 文件。

---
## Mod 演示

https://github.com/user-attachments/assets/c06c3453-937b-4a63-a726-fc0c4238d370

---
## 视频教学
想要动手试试看嘛？点击这里 【【硬核干货】遇到报错怎么办？教你从底层暴力开启《冰与火之舞》官方全自动外挂！】 https://www.bilibili.com/video/BV1neuf64EY9/?share_source=copy_web&vd_source=af1b836b3dccf648b1eeecc5e9541b1e

## 🙏 鸣谢 (Acknowledgments)

- 特别感谢 **[BepInEx 5](https://github.com/BepInEx/BepInEx)** 团队提供的强大而优雅的 Unity Mod 注入框架。没有底层的 Harmony 支持，就没有如此便捷的开发体验。

---
**Author:** Linyouyu
