using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree
{
    public Vector3 Pos;
    public Vector3 Rot;
    public Vector3 Scale;
    public Color BarkColour;
    public Color LeavesColour;
    public TreeAssetGroup AssetGroup;

    public Tree(Vector3 pos, Vector3 rot, Vector3 scale, TreeAssetGroup assetGroup, Color barkColour, Color leavesColour)
    {
        Pos = pos;
        Rot = rot;
        Scale = scale;
        BarkColour = barkColour;
        LeavesColour = leavesColour;
        AssetGroup = assetGroup;
    }
}

public class Model
{
    public int[] Vertices;
    public int[] Triangles;
}

public class TreeAssetGroup
{
    public Texture BarkTexture;
    public Texture LeavesTexture;
    public Model TreeModel;

    public TreeAssetGroup(Texture barkTexture, Texture leavesTexture, Model treeModel)
    {
        BarkTexture = barkTexture;
        LeavesTexture = leavesTexture;
        TreeModel = treeModel;
    }
}
