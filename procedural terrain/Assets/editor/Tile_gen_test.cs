using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Tile_gen_test 
{
    [Test]
    public void check_tree_gen()
    {
        TileGeneration tile_gen = new TileGeneration();
        string x = tile_gen.terrain_type_check;

        if (x == "water")
        {
            Debug.Log("moisture applied to water reigons");
            Debug.Log("heat applied to water reigons");
           
        }

    }

}

public class map_width_height_checker
{
    [Test]
    public void check_map()
    {
        TileGeneration tile_gen = new TileGeneration();
        float Y = tile_gen.size_checker;
        Debug.Log( Y);
        if (Y > 11 || Y < 11)
        {
            Debug.Log("calculated map dimensions have errors");
        }
    }
       

}
