using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GolemScript : MonoBehaviour
{
    public float LookRadius = 10f;
    Transform target;
    NavMeshAgent agen;
    Animator anim;
    public bool Mati=false;
    public bool Bersentuhan;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        target = PlayerManager.instance.Player.transform;
        agen = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance= Vector3.Distance(target.position, transform.position);
        if (distance <= LookRadius){
            if(Bersentuhan==false){
                agen.SetDestination(target.position);
                anim.SetBool("Serang", false);
                anim.SetInteger("Speed",1);
            }else
            {
                anim.SetInteger("Speed",0);
                anim.SetBool("Serang", true);
            }
           }else{
               anim.SetInteger("Speed", 0);
           }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color= Color.red;   
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            Bersentuhan=true;
        }
    }
    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            Bersentuhan=true;
        }
    }
    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            Bersentuhan=false;
        }
    }
}
