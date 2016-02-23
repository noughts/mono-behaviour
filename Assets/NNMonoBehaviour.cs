using UnityEngine;
using System.Collections;

public class NNMonoBehaviour : MonoBehaviour {


	/// インスタンスを生成してスクリプトを返す.
	/// 例: createInstance<Brick>(prefab);
	/// 注意: 生成される位置はプレハブを最後に保存した位置にになるので、生成後、適宜transform.localPositionを設定しましょう。
	public Type createInstance<Type> (GameObject prefab) where Type : MonoBehaviour{
		GameObject g = Instantiate<GameObject>(prefab);
		Type obj = g.GetComponent<Type> ();
		return obj;
	}

}
