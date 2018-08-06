using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MaxScore : MonoBehaviour {


	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
	}

}
