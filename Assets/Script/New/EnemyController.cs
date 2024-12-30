using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {
    // public float lookRadius = 10f;
    // Transform target;
    // NavMeshAgent agent;
    // Animator anim;
    // public bool Attack2 = false;
    // public bool Maju = true;
    // public float MaxNyawaEnemy;
    // public float CurNyawaEnemy = 0;
    // public int KurangiNyawa;
    // public GameObject HealtBarEnemy;
    // public bool Mati = false;
    // public int Point = 0;
    //PlayerKnight playerKnight;



    // Use this for initialization
    void Start() {
        // SetNyawaEnemy();
        // CurNyawaEnemy = MaxNyawaEnemy;
        // SetNyawaEnemy();
        // anim = gameObject.GetComponent<Animator>();
        // playerKnight = gameObject.GetComponent<PlayerKnight>();
        // target = PlayerManager.instance.Player.transform;
        // agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    // void Update() {
        
    //     float distance = Vector3.Distance(target.position, transform.position);
    //     if (distance <= lookRadius)
    //     {                
    //         if (Attack2 == false)
    //         {
    //             DataSave.SerangPlayer = false;
    //             anim.SetBool("Attack2", false);
    //             anim.SetInteger("Speed",1);
    //             if (Maju == true)
    //             {
    //                 agent.SetDestination(target.position);
    //             }            
    //         }
    //         else
    //         {
    //             StartCoroutine(SeranganEnemy());
    //             anim.SetInteger("Speed", 0);
    //             anim.SetBool("Attack2", true);
    //         }
    //     }
    //     if (CurNyawaEnemy <= 0)
    //     {
    //         DataSave.SerangPlayer = false;
    //         DataSave.PlayerPoint += Point;
    //         CurNyawaEnemy = 0;
    //         SetNyawaEnemy();
    //         Mati = true;
    //         anim.SetBool("isDead", true);
    //         StartCoroutine(EnemyDead());
    //     }


    // }
    // IEnumerator SeranganEnemy()
    // {
    //     yield return new WaitForSeconds(0.8f);
    //     DataSave.SerangPlayer = true;

    // }
    // public void KurangiNyawaEnemy()
    // {
    //     CurNyawaEnemy -= KurangiNyawa;
    //     SetNyawaEnemy();
    // }
    // public void KurangiNyawaEnemy2()
    // {
    //     CurNyawaEnemy -= 2 * KurangiNyawa;
    //     SetNyawaEnemy();
    // }
    // public void SetNyawaEnemy()
    // {
    //     if (Mati == false)
    //     {
    //         float HitungNyawa = CurNyawaEnemy / MaxNyawaEnemy;
    //         HealtBarEnemy.transform.localScale = new Vector3(HitungNyawa, HealtBarEnemy.transform.localScale.y, HealtBarEnemy.transform.localScale.z);
    //     }
    //     }
    // IEnumerator EnemyDead()
    // {
    //     yield return new WaitForSeconds(1.2f);
    //     Destroy(this.gameObject);
    // }
    // void OnDrawGizmosSelected()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position, lookRadius);
    // }
    void OnCollisionEnter(Collision col)
    {
        // if (col.gameObject.CompareTag("AnimKnight"))
        // {          
        //     Attack2 = true;
        //     Maju = false;
        // }
       
     }
    void OnCollisionStay(Collision col)
    {
        // if (col.gameObject.CompareTag("AnimKnight"))
        // {
            
        //     Attack2  = true;
        //     Maju = false;
        // }
       
    }
    void OnCollisionExit(Collision col)
    {
        // if (col.gameObject.CompareTag("AnimKnight"))
        // {
        //     Attack2 = false;
        //     Maju = true;
        //     anim.SetBool("Attack2", false);
            
        // }

    }
    void OnTriggerEnter(Collider ot)
    {
        // if (ot.gameObject.CompareTag("Senjata"))
        // {
        //     if (DataSave.SerangEnemy == true)
        //     {
        //         KurangiNyawaEnemy();
        //     }
        // }
        // if (ot.gameObject.CompareTag("Sheraphim"))
        // {
        //     if (DataSave.SerangEnemy == true)
        //     {
        //         KurangiNyawaEnemy2();
        //     }
        // }
    }
}
