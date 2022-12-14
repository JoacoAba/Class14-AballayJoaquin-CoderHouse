using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField][Range(3, 8)] float speed = 5f;
    public Animator PlayerAnimator;
    private float CameraAxisX = 0f;
    [SerializeField][Range(1,2)] float sensitivity = 1f;

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        if(Input.GetKey(KeyCode.W))
        {
            if(!IsAnimating("Run")){PlayerAnimator.SetTrigger("Run");}
            Move(Vector3.forward);
        }
        if(Input.GetKey(KeyCode.A))
        {
            if(!IsAnimating("Run")){PlayerAnimator.SetTrigger("Run");}
            Move(Vector3.left);
        }
        if(Input.GetKey(KeyCode.S))
        {
            if(!IsAnimating("Run")){PlayerAnimator.SetTrigger("Run");}
            Move(Vector3.back);
        }
        if(Input.GetKey(KeyCode.D))
        {
            if(!IsAnimating("Run")){PlayerAnimator.SetTrigger("Run");}
            Move(Vector3.right);
        }
        if(Input.GetKeyUp(KeyCode.W)){if(!IsAnimating("Idle")){PlayerAnimator.SetTrigger("Idle");}}
        if(Input.GetKeyUp(KeyCode.A)){if(!IsAnimating("Idle")){PlayerAnimator.SetTrigger("Idle");}}
        if(Input.GetKeyUp(KeyCode.S)){if(!IsAnimating("Idle")){PlayerAnimator.SetTrigger("Idle");}}
        if(Input.GetKeyUp(KeyCode.D)){if(!IsAnimating("Idle")){PlayerAnimator.SetTrigger("Idle");}}
    }

    bool IsAnimating(string animName)
    {
        return PlayerAnimator.GetCurrentAnimatorStateInfo(0).IsName(animName);
    }

    void Move(Vector3 dir)
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }

    void RotatePlayer()
    {
        CameraAxisX += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, CameraAxisX * sensitivity, 0);
    }
    void Speed(float num)
    {
        speed = num;
    }
}
