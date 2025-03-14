using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCardNum : MonoBehaviour
{
    public void OnClickLeft()
	{
		if (TitleMain.titleMainInstance.useCardNum > 1)
		{
			// カードの使用枚数を変更
			TitleMain.titleMainInstance.useCardNum--;
		}
	}

	public void OnClickRight()
	{
		if (TitleMain.titleMainInstance.useCardNum < 10)
		{
			// カードの使用枚数を変更
			TitleMain.titleMainInstance.useCardNum++;
		}
	}
}
