using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;
    private Animator animator;
    private bool issword, isaxe = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        agent.destination = Target.transform.position;

        if(Input.GetKeyDown(KeyCode.Alpha1) && issword)
        {
            animator.SetTrigger("Sword");
            animator.SetLayerWeight(1, 0.5f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && isaxe)
        {
            animator.SetTrigger("Axe");
            animator.SetLayerWeight(1, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("Crouch");
            animator.SetLayerWeight(2, 1f);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetLayerWeight(2, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)      //if it hits the target
    {
        if (other.name == "Sword")
        {
            Destroy(other.gameObject);
            issword = true;
        }
        if (other.name == "Axe")
        {
            Destroy(other.gameObject);
            isaxe = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
