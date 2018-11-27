# Plugin
## Template library for external plugins

#### Create a new plugin
1. Compile *this* repository.
2. Create a ```Class Library(.NET Framework)``` project.
3. Add the *dll* compiled in the step 1 as COM reference.
4. Create a class named ```O[PluginName]``` or ```I[PluginName]``` implementing the interface ```IInputPlugin``` or ```IOutputPlugin``` depending on the type of plugin.\
Specify the attribute ```PluginName``` with the name that will be used from the command line and *config file* to execute the plugin, be sure to choose a short one.
5. Create a method ```Execute```

#### Examples

##### Input plugin
```c#
namespace plugin
{
    [PluginAttribute(PluginName = "Updates")]
    public class IUpdates : IInputPlugin
    {
        public string Execute()
        {
            ...

            return jsonstring;
        }
    }
}
```

##### Output plugin
```c#
namespace plugin
{
    [PluginAttribute(PluginName = "Console")]
    public class OConsole : IOutputPlugin
    {
        public void Execute(string json, string[] options)
        {
            ...
        }
    }
}
```
