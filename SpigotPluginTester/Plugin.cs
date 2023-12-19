using SpigotFramework.Plugin;

namespace SpigotPluginTester;

public class Plugin : BasePlugin
{
    public override void OnEnable()
    {
        Console.WriteLine("PluginTester is up and running!");
    }
}