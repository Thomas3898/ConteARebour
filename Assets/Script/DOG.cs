using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DOG : MonoBehaviour
{
    public UnityEvent EnoughBread;
    [SerializeField] private float crumbsToEat;
    [SerializeField] private GameObject PoucetRef;
    private float currentCrumbs;
    Rigidbody rgb;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crumb"))
        {
            currentCrumbs++;
            if (currentCrumbs == crumbsToEat)
                EnoughBread.Invoke();
        }
    }

    public void ResetDog()
    {
        gameObject.SetActive(true);
        PoucetRef.GetComponent<Animator>().SetBool("IsTurning", false);
    }
}
