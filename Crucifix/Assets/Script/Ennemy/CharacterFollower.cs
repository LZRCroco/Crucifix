using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterFollower : MonoBehaviour
{
    
    public NavMeshAgent enemy;
    public Transform Player;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    void Update()
    {
        enemy.SetDestination(Player.position);


    }    

}
