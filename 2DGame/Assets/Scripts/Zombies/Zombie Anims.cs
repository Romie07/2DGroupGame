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
    Transform sideShadow;
    ShadowCaster2D shS;
    Transform frontShadow;
    ShadowCaster2D shF;

    void Start()
    {
        zAI = GetComponent<ZombieAI>();
        anim = GetComponent<Animator>();
        spTr = GetComponent<Transform>();
        sideShadow = transform.Find("ShadowCaster Side");
        shS = sideShadow.GetComponent<ShadowCaster2D>();
        frontShadow = transform.Find("ShadowCaster Front");
        shF = sideShadow.GetComponent<ShadowCaster2D>();
        shF.enabled = false;
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
            shS.enabled = true;
            shF.enabled = false;
        }
        else if (xDir > 0 && rotate == false)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            rotate = true;
            shS.enabled = true;
            shF.enabled = false;
        }
        if (yDir != 0 && spTr.)
        {
            shS.enabled = false;
            shF.enabled = true;
        }
        anim.SetFloat("x", xDir);
        anim.SetFloat("y", yDir);
    }
}
