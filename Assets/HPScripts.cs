using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPScripts : MonoBehaviour {
	Slider _slider;
	float _hp = 0;

	// Use this for initialization
	void Start () {
		_slider = GameObject.Find("Slider").GetComponent<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		_hp += 0.5f;
		if(_hp > _slider.maxValue){
			_hp = _slider.minValue;
		}
		
		_slider.value = _hp;
		}

}