
// Pumpkin Particles Colliding:

using UnityEngine;

public class carHit : MonoBehaviour {

    public GameObject car;
    public Collision racingCarCollision;
    public ParticleSystem particles;

    
    void Start()
    {
        
    }

    void Update()
    {
        car.gameObject = transform.position(2, 0, 3);

        

     void OnCollision(Collision collision)
     {
         car.gameObject
         
    
     }

public void AttackPlayer(GameObject playerPos, Animator anim, NavMeshAgent agent, GameObject self, bool MultiAttack, float inRange, float inView, float AttackRange, bool isBlocking, bool HasSeenPLayer)
    {
        distDif = Vector3.Distance(self.transform.position, playerPos.transform.position);

        if (distDif >= AttackRange)
        {
            agent.SetDestination(playerPos.transform.position);
            //anim.SetBool("walk", false);
        }

        else if (distDif <= AttackRange)
        {
            anim.SetBool("walk", false);
        }


             
             
             
}

