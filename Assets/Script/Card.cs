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

	// 選択されているかどうか
	public bool isSelected;

	// カードの情報
	private CardInfo cardInfo;

	// カードの情報をセットする
	public void SetCardInfo(CardInfo cardInfo)
	{
		this.cardInfo = cardInfo;
		this.cardNumber = cardInfo.cardNumber;
		this.cardImage.sprite = Resources.Load<Sprite>("Image/Back");
		this.isSelected = false;
	}

	// ボタンが押されたときの処理
	public void OnClick()
	{
		// 選択されている数が二枚以上の場合は処理しない
		if (CardManager.cardManagerInstance.frontCardList.Count >= 2)
		{
			return;
		}

		// 選択されているかどうか
		if (!this.isSelected)
		{
			// 選択されている場合は非選択状態にする
			this.isSelected = true;

			// イメージを変更
			this.cardImage.sprite = cardInfo.cardImage;

			// managerに選択されたカードを渡す
			CardManager.cardManagerInstance.frontCardList.Add(this);

			Debug.Log("選択されました");
		}
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
