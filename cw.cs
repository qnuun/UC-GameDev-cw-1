using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Fahd";
        int heroage = 15;
        string heroSuperPower = "kick";
        float heroHeight = 23f;

        print("My name is " + heroName + " My age is " + heroage + " My super power is " + heroSuperPower + " My height is " + heroHeight);

        string villainName = "Salem";
        int villainage = 8;
        string villainSuperPower = "puncher";
        float villainHeight = 26f;


        print("My name is " + villainName + " My age is " + villainage + " My superpower is " + villainSuperPower + " My height is " + villainHeight);


        int x1 = 15 - 8;

        print(x1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
