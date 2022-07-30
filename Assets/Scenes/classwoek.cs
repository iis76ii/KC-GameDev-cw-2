using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classwoek : MonoBehaviour
{
    // hero`s and villain`s information 
    void Start()
    {
        string heroname = " itchgo ";
        string herosuperpower = " ban kai ";
        int heroheigth = 174;
        int heroage = 16;
        print("Hi My name is" + heroname + "and my age is " + heroage + " and my superpower is" + herosuperpower + " and my heigth is " + heroheigth );
        string villainname = " aizen ";
        string villainsuperpower = " none ";
        int villainage = 21;
        int villainheight = 186;
        print("hello my name is " + villainname + " and my age is " + villainage + " and my superpower is " + villainsuperpower + " and my heigth is " + villainheight );
        int agedifference = villainage - heroage;
        print(agedifference);
    }
}
