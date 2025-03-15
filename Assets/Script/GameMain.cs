using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{

	// インスタンス
	public static GameMain gameMainInstance;

	// 経過時間
	private float elapsedTime;
	public string timeCnt;

	// カードを選択した数
	public static int selectCardNum = 0;

	// 描画用
	public Text timeText = null;

	// Start is called before the first frame update
	void Start()
    {
		// インスタンスを代入
		gameMainInstance = this;
		elapsedTime = 0.0f;
	}

    // Update is called once per frame
    void Update()
    {
		elapsedTime += Time.deltaTime;
		timeCnt = elapsedTime.ToString("F1");
		timeText.text = timeCnt;

	}

	public static float GetElapsedTime()
	{
		return gameMainInstance.elapsedTime;
	}

	public static int GetSelectCardNum()
	{
		return selectCardNum;
	}

	public void MoveToResult()
	{
		// シーンをロード
		UnityEngine.SceneManagement.SceneManager.LoadScene("result");
	}
}
