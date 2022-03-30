using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    
    public float ileriGitmeHizi;
    
    public float sagaSolaGitmeHizi;
    float zPos;
    

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(ileriGitmeHizi * Time.deltaTime, 0, 0);

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                zPos -= touch.deltaPosition.x * Time.deltaTime * sagaSolaGitmeHizi;
            }
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
         
        if(zPos > 3f)
        {
            zPos = 3f;
        }
        else if (zPos < -3f)
        {
            zPos = -3f;
        }
        

    }


}
