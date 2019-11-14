using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private float _speed;
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    static public int Count = 0;

    private float _attack;
    public float Attack
    {
        get { return _attack; }
        set { _attack = value; }
    }

    public Enemy()
    {
        Name = "Enemy #" + Count;
        Speed = 1;
        Count++;
    }

    public Enemy(string name, float speed)
    {
        Name = name;
        Speed = speed;
        Count++;
    }

    public override string ToString()
    {
        return "Enemy: " + Name + " " + Speed + " " + Attack;
    }
}
