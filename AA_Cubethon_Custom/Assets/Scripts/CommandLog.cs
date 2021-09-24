using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CommandLog 
{

    // This will be a Queue that holds our "Command" lines of what the player did in the game.
    public static Queue<Command> commands = new Queue<Command>();
}
