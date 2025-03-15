using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
	// Œo‰ßŽžŠÔ
	private float elapsedTime;
	public string timeCnt;

	// •`‰æ—p
	public Text timeText = null;

	// Start is called before the first frame update
	void Start()
    {
		elapsedTime = 0.0f;
	}

    // Update is called once per frame
    void Update()
    {
		elapsedTime += Time.deltaTime;
		timeCnt = elapsedTime.ToString("F1");
		timeText.text = timeCnt;
	}
}
