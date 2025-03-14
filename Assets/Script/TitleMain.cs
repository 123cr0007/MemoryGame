using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMain : MonoBehaviour
{
	public int useCardNum;

	// インスタンス
	public static TitleMain titleMainInstance;

	// Start is called before the first frame update
	void Start()
	{
		// インスタンスを代入
		titleMainInstance = this;
		useCardNum = 5;
	}


	// Update is called once per frame
	void Update()
    {
        
    }

	public static int GetUseCardNum()
	{
		// カードの使用枚数を取得
		Debug.Log(titleMainInstance.useCardNum);
		return titleMainInstance.useCardNum;
	}
}
