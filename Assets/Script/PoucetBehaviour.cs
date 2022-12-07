using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoucetBehaviour : MonoBehaviour
{
    public UnityEvent OnTurningEnded;
    //public bool IsTurning = false;
    Animator animator;

    // declencher le retournement
    // check si dog est actif
    // attendre la fin de l'anim
    //avertir le bush de relacher le chien
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TurningStart()
    {
        animator.SetBool("IsTurning", true);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("RotationOut"))
            OnTurningEnded.Invoke();
    }
    
}
