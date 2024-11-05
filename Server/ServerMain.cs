﻿using CitizenFX.Core;

namespace MonoTest.Server;

public class ServerMain: BaseScript
{
    public ServerMain()
    {
        Debug.WriteLine("Hi from MonoTest.Server!");
    }

    [Command("hello_server")]
    public void HelloServer()
    {
        Debug.WriteLine("Sure, hello.");
    }
}
