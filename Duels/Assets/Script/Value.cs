using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour {
    public Slider Slider;
    public float sliderValue;

    
    public float nilai;
    float zero = 0;

    public bool TimeActiveTop = true;

    public bool TimeActive = true;

    [Range(0.5f,10f)]
    public float speed;
	// Use this for initialization
	void Start () {
        nilai = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (TimeActiveTop && TimeActive == true)
        {

            nilai += Time.deltaTime * speed;
            Slider.value = nilai;
            if (nilai > 2)
            {
                TimeActiveTop = false;
            }
        }
        else if (TimeActiveTop == false && TimeActive == true)
        {

            nilai -= Time.deltaTime * speed;

            Slider.value = nilai;
            if (nilai < 0)
            {
                //TimeActiveDown = false;
                TimeActiveTop = true;
            }
        }




	}
   
}
