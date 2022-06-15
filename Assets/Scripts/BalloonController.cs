using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    // sets the number of clicks
    public int clicksToPop = 3;

    void OnMouseDown()
    {
        // decrease the number of clicks
        clicksToPop--;

        // increase the balloon's scale
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        // if we run out of clicks, destroy the balloon
        if (clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
