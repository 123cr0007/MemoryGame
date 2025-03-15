using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMain : MonoBehaviour
{
	public int useCardNum;

	// インスタンス
	public static TitleMain titleMainInstance = null;
	public static bool isTitle = false;

	// Start is called before the first frame update
	void Start()
	{
		// インスタンスを代入
		titleMainInstance = this;
		useCardNum = 5;
		isTitle = true;
	}


	// Update is called once per frame
	void Update()
    {
        
    }

	public static int GetUseCardNum()
	{
		if (isTitle == false)
		{
			// タイトルをロード
			SceneManager.LoadScene("title");
		}

		// カードの使用枚数を取得
		Debug.Log(titleMainInstance.useCardNum);
		return titleMainInstance.useCardNum;
	}
}
