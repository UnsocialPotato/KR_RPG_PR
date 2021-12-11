/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    public int player = 0;
    public GameObject playerskin;

    public void NextOption()
    {
        player = player + 1;
        if (player == skins.Count)
        {
            player = 0;
        }
        sr.sprite = skins[player];
    }

    public void BackOption()
    {
        player = player - 1;
        if (player < 0)
        {
            player = skins.Count - 1;
        }
        sr.sprite = skins[player];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Resources/Player.prefab");
        SceneManager.LoadScene("Menu");
    }
}*/
