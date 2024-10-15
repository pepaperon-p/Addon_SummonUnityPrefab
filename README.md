# Addon_SummonUnityPrefab
![Unity_舞台裏](https://github.com/user-attachments/assets/77a4bb70-2b1f-477a-88a8-8b3a4a14e6b3)
| Addon |
|:-----------|
| [SummonUnityPrefab.cs](https://raw.githubusercontent.com/pepaperon-p/Addon_SummonUnityPrefab/main/SummonUnityPrefab/SummonUnityPrefab.cs "SummonUnityPrefab.cs")|

任意のUnityプレハブをイベント指定位置に召喚します。<br/>
プレハブはプロジェクトの以下の位置に配置してください。<br/>
プロジェクト/Assets/Resources/Prefab

```
/*
 * @command LoadPrefab
 *      @text プレハブを召喚
 *      @desc 任意のプレハブを指定位置に召喚します。
 * 
 *  @arg name
 *      @text プレハブ名称
 *      @desc 召喚するプレハブ名を指定。<br>プロジェクト/Assets/Resources/Prefab/[name]
 *      @type string
 *
 *  @arg x
 *      @text 位置x
 *      @desc 基本はイベントと同じx値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *
 *  @arg y
 *      @text 位置y
 *      @desc 基本はイベントと同じy値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 */
public void LoadPrefab(string name, double x, double y)
```
