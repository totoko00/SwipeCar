using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car"); //Findメソッド「オブジェクト名を引数に取り、引数名と同じものがゲームシーン中にあれば、そのオブジェクトを返す」
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";   
        }
        else
        {
            this.distance.GetComponent<Text>().text = "ゲームオーバー";
        }
    }
}
