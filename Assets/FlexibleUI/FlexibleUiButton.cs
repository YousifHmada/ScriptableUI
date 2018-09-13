using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class FlexibleUiButton : FlexibleUI {
	Image image;
	Button button;

	public override void Awake(){
		base.Awake();
		image = GetComponent<Image>();
		button = GetComponent<Button>();
		Debug.Log("lol");
	}
}
