using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("# Game Control")]
    public float gameTime;
    public float amxGameTime = 2 * 10f;
    [Header("# Player Info")]  
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = {3, 5, 10, 100, 150,210, 280,360, 450, 600};

    [Header("# Game Object")]
    public PoolManager pool;
    public Player player;

    void Awake(){
        instance = this;
    }
   
    void Update()
    {
        gameTime += Time.deltaTime;

        if(gameTime > amxGameTime){
            gameTime = amxGameTime;
        }
    }  

    public void GetExp()
    {
        exp++;

        if(exp == nextExp[level]){
            level++;
            exp = 0;
        }
    }
}
