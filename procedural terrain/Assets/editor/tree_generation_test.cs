using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class tree_generation_test 
{
  [Test]
  public void check_tree_gen()
    {
        float expected_error = 5; 
        TreeGeneration checker = new TreeGeneration();

        if(checker.counter >5)
        {

            Debug.Log("Max value error");
        }

    }
}
public class Testing
{

    [Test]
    public void Testing_maxvalue()
    {
        TreeGeneration treegen = new TreeGeneration();

        float max = treegen.check_maxvalue;
        float treevalue = treegen.check_this_tree;

        if (max > treevalue)
        {
            Debug.Log("Tree generation max value bug");
            treegen.counter = treegen.counter + 1;
        }

    }

}

public class layer_testing  /////////intergration Terraintype class and treegeneration class
{
    [Test]
    public void Testing_layer()
    {
        TreeGeneration treegen = new TreeGeneration();
        TerrainType[,] ter = new TerrainType[11, 11];

        if (treegen.terrain_type=="water")
        {
            Debug.Log("trees generated on water layer");
        }

    }

}