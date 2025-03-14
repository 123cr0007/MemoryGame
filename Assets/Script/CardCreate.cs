using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;


public class CardCreate : MonoBehaviour
{
	// カードのプレハブ
	public Card cardPrefab;

	// グリッド（フィールド）
	public Transform grid;

	//　各マーク何枚まで使用するか
	// タイトルの画面で設定する
	private int cardNumber = TitleMain.GetUseCardNum();

	// Start is called before the first frame update
	void Start()
    {
		// ここテスト　
		//Card card = Instantiate<Card>(this.cardPrefab, this.grid);

		// カードデータのリスト
		List<CardInfo> cardInfoList = new List<CardInfo>();
		List<string> cardImageName = new List<string>();
		// カードの画像リスト
		List<Sprite> cardImageList = new List<Sprite>();

		for(int i = 0; i < cardNumber; i++)
		{
			// カードの番号
			string cardNum = i.ToString("00");//数値を桁数指定で文字列に変換

			// カードのマーク
			string spade = "spade";
			string heart = "heart";
			string diamond = "diamond";
			string clover = "clover";

			// カードの画像の名前
			string cardImageSpade = cardNum + "_" + spade;
			string cardImageHeart = cardNum + "_" + heart;
			string cardImageDiamond = cardNum + "_" + diamond;
			string cardImageClub = cardNum + "_" + clover;

			// カードの画像をロード
			Sprite cardImage = Resources.Load<Sprite>("Image/" + spade + "/" + cardImageSpade);
			if (cardImage != null)
			{
				cardImageList.Add(cardImage);
				cardImageName.Add(cardImageSpade);
			}
			cardImage = Resources.Load<Sprite>("Image/" + heart + "/" + cardImageHeart);
			if (cardImage != null)
			{
				cardImageList.Add(cardImage);
				cardImageName.Add(cardImageHeart);
			}
			cardImage = Resources.Load<Sprite>("Image/" + diamond + "/" + cardImageDiamond);
			if (cardImage != null)
			{
				cardImageList.Add(cardImage);
				cardImageName.Add(cardImageDiamond);
			}
			cardImage = Resources.Load<Sprite>("Image/" + clover + "/" + cardImageClub);
			if (cardImage != null)
			{
				cardImageList.Add(cardImage);
				cardImageName.Add(cardImageClub);
			}
		}

		// カードの情報を作成
		int cardImageListCount = cardImageList.Count;
		for (int i = 0; i < cardImageListCount; i++)
		{
			string cardNum = cardImageName[i].Substring(0, 2);
			Debug.Log(int.Parse(cardNum));
			CardInfo cardInfo = new CardInfo(int.Parse(cardNum), cardImageList[i]);
			cardInfoList.Add(cardInfo);
		}

		// カードのリストをシャッフル
		cardInfoList = cardInfoList.OrderBy(value => Guid.NewGuid()).ToList();

		// カードの生成
		foreach (CardInfo cardInfo in cardInfoList)
		{
			Card card = Instantiate<Card>(this.cardPrefab, this.grid);
			card.SetCardInfo(cardInfo);
		}
	}
}
