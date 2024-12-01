using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool isPressed;
    private Animator animator;
    public GameObject portal;
    public float remainingTime;
    Coroutine timer;

    public void ClickButton(){
        animator.SetTrigger("TriPressed");
        if(portal.activeInHierarchy == false){
            portal.SetActive(true);
            if(timer != null){
                StopCoroutine(timer);
            }
            timer = StartCoroutine(Timer());
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer(){
        yield return new WaitForSeconds(30);
        portal.SetActive(false);
    }
}
