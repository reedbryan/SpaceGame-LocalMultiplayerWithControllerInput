using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPS : MonoBehaviour
{
    ParticleSystem particleSystem;

    public int starCount;
    /// <summary>
    /// If this is = to 1 size will not change, if this is = to 2 size will double etc...
    /// </summary>
    public float avStarSizeMul;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        var main = particleSystem.main;
        main.startLifetime = 100000;
        main.maxParticles = starCount;
    }

    private void Update()
    {
        
    }
}
