using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

interface IInteractable{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            if(Input.GetKeyDown(KeyCode.E)){
                interactAction.Invoke();
            }
        }
    }
}
