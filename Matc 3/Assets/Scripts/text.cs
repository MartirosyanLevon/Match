using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
    private Text txt;


    void Start () {
        txt = GetComponent<Text>();
    }


    void Update () {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b,Mathf.PingPong(Time.time/2.5f,0.5f));
	}
}
