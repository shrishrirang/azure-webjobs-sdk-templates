using System;

public static void Run(string msg, TraceWriter log)
{
    log.Info($"SQL function triggered : {msg}");
}
