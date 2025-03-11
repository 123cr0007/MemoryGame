using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreate : MonoBehaviour
{
	// カードのプレハブ
	public Card cardPrefab;

	// グリッド（フィールド）
	public Transform grid;

	private int cardNumber = 13;

	// Start is called before the first frame update
	void Start()
    {
		// ここテスト　Card card = Instantiate<Card>(this.cardPrefab, this.grid);

		// カードデータのリスト
		List<CardInfo> cardInfoList = new List<CardInfo>();
		// カードの画像リスト
		List<Sprite> cardImageList = new List<Sprite>();

		for(int i = 0; i < cardNumber; i++)
		{
			string cardNum = i.ToString("00");//数値を桁数指定で文字列に変換
			Debug.Log(cardNum);
		}
	}
}
