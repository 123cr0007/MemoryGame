using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseCardUi : MonoBehaviour
{

	public Text cardNum = null;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		int useCardNum = TitleMain.titleMainInstance.useCardNum;
		// カードの使用枚数を表示
		// ここでTitleMainのインスタンスからuseCardNumを取得して表示
		cardNum.text = useCardNum.ToString();

	}
}
