using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    [SerializeField]
    private float fillAmount;

    [SerializeField] private Image content;

    public float MaxValue { get; set; }
    
    public float Value
    {
        set
        {
            fillAmount = Map(value, 0 , MaxValue, 0 , 1);
        }
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        HandleBar();

	}

    private void HandleBar()
    {
        if (fillAmount != content.fillAmount)
            content.fillAmount = fillAmount;
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {

        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin; 
        // (80 - 0) * (1 - 0) / (100 - 0) + 0
        //     80   *    1    /     100   + 0 = .8

        //in max is the ingame health of the player
        //outmax and outmin are 1 and 0 because thats what the slider is
    }

}
