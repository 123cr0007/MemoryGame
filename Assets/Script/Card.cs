using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	// Card class
	// カードのマーク（スペードとか）
	public string cardMark;

	// カードの数字（1~13）
	public int cardNumber;

	// イメージ
	public Sprite cardImage;

}

// カードの情報クラス
// ここでデータを作った後、Cardにデータを渡す
public class CardInfo
{
	// 読み込み専用のプロパティにしたいためprivate set;をつける
	// カードのマーク（スペードとか）
	public string cardMark { get; private set; }
	// カードの数字（1~13）
	public int cardNumber { get; private set; }
	// イメージ
	public Sprite cardImage { get; private set; }

	// コンストラクタ
	public CardInfo(string cardMark, int cardNumber, Sprite cardImage)
	{
		this.cardMark = cardMark;
		this.cardNumber = cardNumber;
		this.cardImage = cardImage;
	}
}
