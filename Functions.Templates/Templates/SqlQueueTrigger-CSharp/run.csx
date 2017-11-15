using System;

public static void Run(string msg, TraceWriter log)
{
    log.Info($"## C# SQL queue trigger function processed message : {msg}");
}
