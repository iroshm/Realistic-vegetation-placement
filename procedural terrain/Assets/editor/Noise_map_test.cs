using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Noise_map_test 
{
    [Test]
    public void check_nosie_normalization()
    {
        NoiseMapGeneration noisemap_gen = new NoiseMapGeneration();

        if(  noisemap_gen.noise < 0)
        {
            Debug.Log("Normalized noise value less than 0");
        }
        if (noisemap_gen.noise > 1)
        {
            Debug.Log("Normalized noise value greater than 1");
        }
        

    }
}
