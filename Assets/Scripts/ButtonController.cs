using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool isPressed;
    public Animator animator;

    public void ClickButton(){
        if(!isPressed){
            isPressed = true;
            animator.SetBool("IsPressed", isPressed);
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
