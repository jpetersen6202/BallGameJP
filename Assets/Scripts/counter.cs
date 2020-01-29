using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class counter : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        winText.text = "";   
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "projectile"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
