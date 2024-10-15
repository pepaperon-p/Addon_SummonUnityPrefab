/*:
 * @addondesc Summon a Unity prefab
 * @author pepaperon-p
 * @help [version 1.0.0]
 * Summons any Unity prefab to a specified position.
 * Place the prefab in the following location in your project.
 * Project/Assets/Resources/Prefab
 * 
 * @command LoadPrefab
 *      @text Summon a Prefab
 *      @desc Summons a prefab to a specified location.
 * 
 *  @arg name
 *      @text Prefab Name
 *      @desc Specify the name of the prefab to summon. <br>Project/Assets/Resources/Prefab/[name]
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
 */

/*:ja
 * @addondesc Unityのプレハブを召喚します
 * @author ぺぱぺろん(pepaperon-p)
 * @help [version 1.0.0]
 * 任意のUnityプレハブを指定位置に召喚します。
 * プレハブはプロジェクトの以下の位置に配置してください。
 * プロジェクト/Assets/Resources/Prefab
 * 
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
        obj.transform.localPosition = new Vector3((float)x, -1 * (float)y, -5);
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = new Vector3(1, 1, 1);
      }
    }
  }
}
