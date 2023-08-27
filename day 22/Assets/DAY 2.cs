using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAY2 : MonoBehaviour
{
    string heroname = "Tota";
    int Heropower = 1500;
    float playerspeed = 6.2f;
    string villainName = "Aziz";
    int villainpower = 1501;
    // Start is called before the first frame update
    void Start()
    {
        if (Heropower > villainpower)
        {
            print("heropower stronger then villainpower");
        }
        else if (villainpower > Heropower)
        {
            print("villainpower stronger then heropower");
        }
       else
        {
            print("heropower equal villainpower");
}       }
         print(playerspeed);
         Setspeed(2,5f);
    print(playerspeed);
    // Update is called once per frame
    void Update()
    {
        
    }
}    void Setspeed(float speed )
{
    playerspeed = speed;
}
