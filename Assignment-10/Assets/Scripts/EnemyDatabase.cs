using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatabase : MonoBehaviour
{
    public Dictionary<string, Enemy> Enemies = new Dictionary<string, Enemy>();

    private void Start()
    {
        Enemies.Add("generic enemy", new Enemy());
        Enemies.Add("fast enemy", new Enemy("Speedy", 2f));
        Enemies.Add("slow enemy", new Enemy("Tanky", 0.5f));

        if (Enemies.ContainsKey("generic enemy"))
        {
            Enemies.Remove("generic enemy");
        }

        foreach (KeyValuePair<string, Enemy> E in Enemies)
        {
            Debug.Log(E.Key + " = " + E.Value.ToString());
        }
    }
}
