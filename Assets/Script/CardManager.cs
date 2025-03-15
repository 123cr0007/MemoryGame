using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カードのマネージャー
//先に処理させたい
[DefaultExecutionOrder(-1)]
public class CardManager : MonoBehaviour
{
	// インスタンス
	public static CardManager cardManagerInstance;

	// 表のカードのリスト
	public List<Card> frontCardList;

	// 裏返すカウント
	public float turnCount;
	private const float TURN_MAX_CNT = 1.0f;



	// Start is called before the first frame update
	void Start()
	{
		// インスタンスが存在しない場合
		if (cardManagerInstance == null)
		{
			// このオブジェクトをインスタンスにする
			cardManagerInstance = this;
		}

		// リストを初期化
		frontCardList = new List<Card>();

		// カウントを初期化
		turnCount = 0;
	}

	// Update is called once per frame
	void Update()
    {
		// 表のカードが2枚以上の場合
		if (frontCardList.Count >= 2)
		{
			// カウントが最大値を超えた場合
			if (turnCount > TURN_MAX_CNT)
			{
				// カードの番号が同じ場合
				if (frontCardList[0].cardNumber == frontCardList[1].cardNumber)
				{
					// カードを消す
					Destroy(frontCardList[0].gameObject);
					Destroy(frontCardList[1].gameObject);
				}
				else
				{
					// カードを裏にする
					frontCardList[0].cardImage.sprite = Resources.Load<Sprite>("Image/Back");
					frontCardList[1].cardImage.sprite = Resources.Load<Sprite>("Image/Back");

					// カードの選択を解除
					frontCardList[0].isSelected = false;
					frontCardList[1].isSelected = false;
				}

				// 初期化
				frontCardList.Clear();
				turnCount = 0;
			}
			else
			{
				turnCount += Time.deltaTime;
			}

		}
	}
}
