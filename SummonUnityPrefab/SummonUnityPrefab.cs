/*:
 * @addondesc Summon a Unity prefab
 * @author pepaperon-p
 * @help [version 2.0.0]
 * Summons any Unity prefab to a specified position.
 * Place the prefab in the following location in your project.
 * Project/Assets/Resources/Prefab
 *
 * version 2.0.0 Summon a Prefab(Rotation, Size) add
 *
 * @command LoadPrefab
 *      @text Summon a Prefab
 *      @desc Summons a prefab to a specified location.
 * 
 *  @arg name
 *      @text Prefab Name
 *      @desc Specify the name of the prefab to summon. <br/>Project/Assets/Resources/Prefab/[name]
 *      @type string
 *
 *  @arg x
 *      @text Position x
 *      @desc Basically, set the x value to the same as the event (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *
 *  @arg y
 *      @text Position y
 *      @desc Basically, set the same y value as the event (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *
 * @command LoadPrefabRotScale
 *      @text Summon a Prefab(Rotation, Size)
 *      @desc Summon any prefab to a specified position with rotation and size adjustment.
 * 
 *  @arg name
 *      @text Prefab Name
 *      @desc Specify the name of the prefab to summon. <br/>Project/Assets/Resources/Prefab/[name]
 *      @type string
 *
 *  @arg x
 *      @text Position x
 *      @desc Basically, set the x value to the same as the event (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *
 *  @arg y
 *      @text Position y
 *      @desc Basically, set the same y value as the event (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *
 *  @arg z
 *      @text Position z
 *      @desc Set the z value as desired (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *      @default 5
 *
 *  @arg xRot
 *      @text Rotaion x
 *      @desc Set the Euler angle x value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg yRot
 *      @text Rotaion y
 *      @desc Set the Euler angle y value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg zRot
 *      @text Rotaion z
 *      @desc Set the Euler angle z value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg xScale
 *      @text Size x
 *      @desc Set the size magnification x value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 *
 *  @arg yScale
 *      @text Size y
 *      @desc Set the size magnification y value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 *
 *  @arg zScale
 *      @text Size z
 *      @desc Set the size magnification z value (this can be fine-tuned with a decimal point).
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 */

/*:ja
 * @addondesc Unityのプレハブを召喚します
 * @author ぺぱぺろん(pepaperon-p)
 * @help [version 2.0.0]
 * 任意のUnityプレハブを指定位置に召喚します。
 * プレハブはプロジェクトの以下の位置に配置してください。
 * プロジェクト/Assets/Resources/Prefab
 * 
 * version 2.0.0 プレハブを召喚(回転、サイズ)追加
 *
 * @command LoadPrefab
 *      @text プレハブを召喚
 *      @desc 任意のプレハブを指定位置に召喚します。
 * 
 *  @arg name
 *      @text プレハブ名称
 *      @desc 召喚するプレハブ名を指定。<br/>プロジェクト/Assets/Resources/Prefab/[name]
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
 *
 * @command LoadPrefabRotScale
 *      @text プレハブを召喚(回転、サイズ)
 *      @desc 任意のプレハブを指定位置に回転、サイズ調整有りの召喚をします。
 * 
 *  @arg name
 *      @text プレハブ名称
 *      @desc 召喚するプレハブ名を指定。<br/>プロジェクト/Assets/Resources/Prefab/[name]
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
 *
 *  @arg z
 *      @text 位置z
 *      @desc 必要に応じてz値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 9999
 *      @min -9999
 *      @decimals 2
 *      @default 5
 *
 *  @arg xRot
 *      @text 回転x
 *      @desc オイラー角x値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg yRot
 *      @text 回転y
 *      @desc オイラー角y値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg zRot
 *      @text 回転z
 *      @desc オイラー角z値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 360
 *      @min -360
 *      @decimals 2
 *
 *  @arg xScale
 *      @text サイズx
 *      @desc サイズ倍率x値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 *
 *  @arg yScale
 *      @text サイズy
 *      @desc サイズ倍率y値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 *
 *  @arg zScale
 *      @text サイズz
 *      @desc サイズ倍率z値を設定（小数点で微調整できます）。
 *      @type number
 *      @max 999
 *      @min -999
 *      @decimals 2
 *      @default 1
 */

using System.Collections.Generic;
using RPGMaker.Codebase.CoreSystem.Knowledge.DataModel.Runtime;
using RPGMaker.Codebase.Runtime.Addon;
using RPGMaker.Codebase.Runtime.Common;
using UnityEngine;

namespace RPGMaker.Codebase.Addon
{
  public class SummonUnityPrefab : MonoBehaviour
  {

    public void LoadPrefab(string name, double x, double y)
    {
      GameObject clone = GameObject.Find(name + "(Clone)");
      if (clone == null)
      {
        GameObject prefab = Resources.Load<GameObject>("Prefab/" + name);
        GameObject root = GameObject.Find("Root");
        GameObject obj = Instantiate(prefab, root.transform);
        // 位置
        obj.transform.localPosition = new Vector3((float)x, -1 * (float)y, -5);
        // 回転
        obj.transform.localRotation = Quaternion.Euler(0, 0, 0);
        // サイズ
        obj.transform.localScale = new Vector3(1, 1, 1);
      }
    }

    public void LoadPrefabRotScale(string name,
      double x, double y, double z,
      double xRot, double yRot, double zRot,
      double xScale, double yScale, double zScale)
    {
      GameObject clone = GameObject.Find(name + "(Clone)");
      if (clone == null)
      {
        GameObject prefab = Resources.Load<GameObject>("Prefab/" + name);
        GameObject root = GameObject.Find("Root");
        GameObject obj = Instantiate(prefab, root.transform);
        // 位置
        obj.transform.localPosition = new Vector3((float)x, -1 * (float)y, -1 * (float)z);
        // 回転
        obj.transform.localRotation = Quaternion.Euler((float)xRot, (float)yRot, (float)zRot);
        // サイズ
        obj.transform.localScale = new Vector3((float)xScale, (float)yScale, (float)zScale);
      }
    }
  }
}
