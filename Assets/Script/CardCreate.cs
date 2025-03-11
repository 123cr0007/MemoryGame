using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreate : MonoBehaviour
{
	// カードのプレハブ
	public Card cardPrefab;

	// グリッド（フィールド）
	public Transform grid;

	private int cardNumber = 1;

	// Start is called before the first frame update
	void Start()
    {
		// ここテスト　
		Card card = Instantiate<Card>(this.cardPrefab, this.grid);

		// カードデータのリスト
		List<CardInfo> cardInfoList = new List<CardInfo>();
		// カードの画像リスト
		List<Sprite> cardImageList = new List<Sprite>();

		for(int i = 0; i < cardNumber; i++)
		{
			// カードの番号
			string cardNum = i.ToString("00");//数値を桁数指定で文字列に変換

			//// カードのマーク
			//string spade = "spade";
			//string heart = "heart";
			//string diamond = "diamond";
			//string clover = "clover";

			//// カードの画像の名前
			//string cardImageSpade = cardNum + "_" + spade;
			//string cardImageHeart = cardNum + "_" + heart;
			//string cardImageDiamond = cardNum + "_" + diamond;
			//string cardImageClub = cardNum + "_" + clover;

			//Debug.Log(cardImageSpade);
			//Debug.Log("Image/" + spade + "/" + cardImageSpade);

			//// カードの画像をロード
			//Sprite cardImage = Resources.Load<Sprite>("Image/" + spade + "/" + cardImageSpade);
			//Debug.Log(cardImage);
			//if (cardImage != null) cardImageList.Add(cardImage);
			//cardImage = Resources.Load<Sprite>("Image/" + heart + "/" + cardImageHeart);
			//if (cardImage != null) cardImageList.Add(cardImage);
			//cardImage = Resources.Load<Sprite>("Image/" + diamond + "/" + cardImageDiamond);
			//if (cardImage != null) cardImageList.Add(cardImage);
			//cardImage = Resources.Load<Sprite>("Image/" + clover + "/" + cardImageClub);
			//if (cardImage != null) cardImageList.Add(cardImage);
		}
	}
}
