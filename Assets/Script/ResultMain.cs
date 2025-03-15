using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultMain : MonoBehaviour
{

	public Text t_GameTime;
	public Text t_SelectCardNum;

	private float elapsedTime;
	private int selectCardNum;

	// Start is called before the first frame update
	void Start()
    {
		elapsedTime = GameMain.GetSelectCardNum();
		selectCardNum = GameMain.GetSelectCardNum();
	}

    // Update is called once per frame
    void Update()
    {
		t_GameTime.text = "Ç©Ç©Ç¡ÇΩéûä‘ÅF" + elapsedTime.ToString("F1");
		t_SelectCardNum.text = "éËêîÅF" + selectCardNum;
	}
}
