using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command 
{
    public Rigidbody _player;
    public float timestamp;
    public abstract void Execute();
}


public class MoveLeft : Command
{
    private float _force;

    public MoveLeft(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }


    public override void Execute()
    {
        //Doing the force here instead and adding a timestamp of when it was implemented
        timestamp = Time.timeSinceLevelLoad;    
        _player.AddForce(-_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

public class MoveRight : Command
{
    private float _force;

    public MoveRight(Rigidbody player, float force)
    {
        _player = player;
        _force = force;

    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}