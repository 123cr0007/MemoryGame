using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	// カードの数字（1~13）
	public int cardNumber;

	// イメージ
	public Image cardImage;

	// カードの情報をセットする
	public void SetCardInfo(CardInfo cardInfo)
	{
		this.cardNumber = cardInfo.cardNumber;
		this.cardImage.sprite = cardInfo.cardImage;
	}
}

// カードの情報クラス
// ここでデータを作った後、Cardにデータを渡す
public class CardInfo
{
	// 読み込み専用のプロパティにしたいためprivate set;をつける
	// カードの数字（1~13）
	public int cardNumber { get; private set; }
	// イメージ
	public Sprite cardImage { get; private set; }

	// コンストラクタ
	public CardInfo(int cardNumber, Sprite cardImage)
	{
		this.cardNumber = cardNumber;
		this.cardImage = cardImage;
	}
}
