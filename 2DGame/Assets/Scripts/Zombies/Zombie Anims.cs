using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ZombieAnims : MonoBehaviour
{
    Transform spTr;
    Animator anim;
    ZombieAI zAI;
    Vector3 dir;
    bool rotate = false;
    Transform shF;
    Transform shS;

    void Start()
    {
        zAI = GetComponent<ZombieAI>();
        anim = GetComponent<Animator>();
        spTr = GetComponent<Transform>();
        shS = transform.Find("ShadowCaster Side");
        shF = transform.Find("ShadowCaster Front");
        shF.GetComponent<ShadowCaster2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    { 
        dir = zAI.getDir();
        float xDir = dir.x;
        float yDir = dir.y;
        if (xDir < 0 && rotate == true)
        {
            transform.rotation = Quaternion.Euler (0, 0, 0);
            rotate = false;
            shS.GetComponent<ShadowCaster2D>().enabled = true;
            shF.GetComponent<ShadowCaster2D>().enabled = false;
        }
        else if (xDir > 0 && rotate == false)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            rotate = true;
            shS.GetComponent<ShadowCaster2D>().enabled = true;
            shF.GetComponent<ShadowCaster2D>().enabled = false;
        }
        if (yDir < 0)
        {
            shS.GetComponent<ShadowCaster2D>().enabled = false;
            shF.GetComponent<ShadowCaster2D>().enabled = true;
        }
        else if (yDir > 0)
        {
            shS.GetComponent<ShadowCaster2D>().enabled = false;
            shF.GetComponent<ShadowCaster2D>().enabled = true;
        }
        anim.SetFloat("x", xDir);
        anim.SetFloat("y", yDir);
    }
}
