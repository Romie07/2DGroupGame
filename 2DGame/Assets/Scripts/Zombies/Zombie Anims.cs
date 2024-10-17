using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnims : MonoBehaviour
{
    Transform spTr;
    Animator anim;
    ZombieAI zAI;
    Vector3 dir;
    bool rotate = false;
    GameObject shF;
    GameObject shS;

    void Start()
    {
        zAI = GetComponent<ZombieAI>();
        anim = GetComponent<Animator>();
        spTr = GetComponent<Transform>();
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
        }
        else if (xDir > 0 && rotate == false)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            rotate = true;
        }
        anim.SetFloat("x", xDir);
        anim.SetFloat("y", yDir);
    }
}
