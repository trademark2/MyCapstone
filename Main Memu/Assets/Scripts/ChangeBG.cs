using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeBG : MonoBehaviour
{
	public Canvas Forest_set;
    public Canvas Cave_set;


    void Awake()
    {
        Cave_set.enabled = true;
        Forest_set.enabled = false;
     
    }
    public void forestOn()
    {
        Cave_set.enabled = false;
        Forest_set.enabled = true;
       
    }

}
