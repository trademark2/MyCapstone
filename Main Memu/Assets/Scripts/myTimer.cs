using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Very Important !!! 

public class myTimer : MonoBehaviour {

    private float myCoolTimer = 30;
    public Text textTimerRefrence;
    public float rawTime = 0;
    private float refinedTime = 0;



    public float RefinedTime
    {
        get
        {
            return refinedTime;
            //this is what other methods get that rely on time, its the time without decimal places
        }

        set
        {
            refinedTime = value;
        }
    }

    public float MyCoolTimer
    {
        get
        {
            return myCoolTimer;
        }

        set
        {
            myCoolTimer = value;
            //this is what you set to alter the time, this is the true time with decimal places
        }
    }


    // Use this for initialization
    void Start()
    {
        textTimerRefrence = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        MyCoolTimer -= Time.deltaTime;
        RefinedTime = Map(MyCoolTimer);
        textTimerRefrence.text = RefinedTime.ToString("f0");
        print(RefinedTime);


    }

    float Map(float rawTime)
    {
        return Mathf.RoundToInt(rawTime);
    }

    void Round()

    {


    }



}
