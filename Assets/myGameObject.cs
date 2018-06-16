using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    private string name;
    private string color;
    private int speed;

    Car()
    {
        speed = 100;

    }

    public void setName(string n)
    {
        this.name = n;
    }

    public void setColor(string c)
    {
        this.color = c;
    }

    public void setSpeed(int s)
    {
        this.speed = s;
        if (this.speed <= 0)
        {
            speed = 1;
        }
    }

    private void testOutputLog()
    {
        int miles = 1600 / speed;

        Debug.Log(this.name);
        Debug.Log(this.color);
        Debug.Log(this.speed);

        //	setCar( );
    }

}

public class Toyota : Car
{
    int yen;
}
public class Wagen : Car
{
    int doller;
}


public class myGameObject : MonoBehaviour {

    private Car hensuu;

    // Use this for initialization
    void Start () {
    hensuu = new Car();
    Debug.Log("alsdkfjalsdkf");

    }

// Update is called once per frame
void Update () {

        //hensuu.name = "Tanto";
        //hensuu.color = "White";
        //hensuu.speed = 0;

        hensuu.setName("Tanto");
        hensuu.setSpeed(15);
        hensuu.setColor("White");

        hensuu.testOutputLog();

    }
}
