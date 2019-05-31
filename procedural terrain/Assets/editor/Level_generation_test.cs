using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Level_generation_test // ////// intergration between levels and tiles
{
    [Test]
    public void check_level_gen()
    {
        LevelGeneration level_gen = new LevelGeneration();

        if (level_gen.tile == null)
        {
            Debug.Log("tiles are saved as gameobject");
        }

    }
}
