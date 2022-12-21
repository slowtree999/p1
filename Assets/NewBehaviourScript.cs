using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("hello unity!");

        int Level = 5;
        float strenght = 15.6f;
        string playernName = "dsd";
        bool isFullLevel = false;

        Debug.Log("용사의 이름은?");
        Debug.Log(playernName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(Level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strenght);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);


        string[] monsters = { "ㅛ", "ㄴ", "ㅇ" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);



    }

 

   

   
}
