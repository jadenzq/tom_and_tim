using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{   
    public Transform destination;
    Coroutine timer;

    public GameObject box;
    public GameObject currentPortal;
    public GameObject targetPortal;
    public GameObject player;
    public void Teleport(){
        if(targetPortal.activeInHierarchy == false){
            targetPortal.SetActive(true);
            player.transform.position = currentPortal.GetComponent<PortalController>().GetDestination().position;
            if(timer != null){
                StopCoroutine(timer);
            }
            timer = StartCoroutine(Timer());
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

    IEnumerator Timer(){
        yield return new WaitForSeconds(2);
        targetPortal.SetActive(false);
    }

    public Transform GetDestination(){
        return destination;
    }

    public void GenerateBox(){
        if(box.activeInHierarchy == false){
            box.SetActive(true);
        }
    }
}
