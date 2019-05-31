using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class tile_coordinate_test : MonoBehaviour
{
    
    private int levelWidthInTiles, levelDepthInTiles;
    private int zIndex;
    private int xIndex;


    [Test]
    public void tile_coordinate_tester()   /////////////////intergration lavel data class with tile coordinate class
    {
        LevelGeneration LG = new LevelGeneration();
        levelWidthInTiles = 2;
        levelWidthInTiles = 2;
        zIndex = 3;
        xIndex = 4;
        LevelData LD = new LevelData(11,11,2,2);
        TileCoordinate test= LD.ConvertToTileCoordinate(zIndex, xIndex);

         if (test == null)
          {

          Debug.Log("null object returned");
        }

    }
}
