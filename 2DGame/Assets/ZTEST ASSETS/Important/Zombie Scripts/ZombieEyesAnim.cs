using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEyesAnim : MonoBehaviour
{
    // Start is called before the first frame update
    Transform spTr;
    Animator anim;
    ZombieAI zAI;
    Vector3 dir;

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
        anim.SetFloat("x", xDir);
        anim.SetFloat("y", yDir);
    }
}