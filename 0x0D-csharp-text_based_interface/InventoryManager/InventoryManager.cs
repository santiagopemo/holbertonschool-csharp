using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;


class Program
{
    private static readonly JSONStorage<BaseClass> jsonStorage = new JSONStorage<BaseClass>();
    private delegate int method(string[] input);
    private static Dictionary<string, method> methods;
    private static Dictionary<string, string> classes;


    static void Main(string[] args)
    {
        string command = null;
        string[] commands = null;
        jsonStorage.Load();
        Initialize();
        PrintInitalPromt();
        while (true)
        {
            PrintPrompt();
            command = Console.ReadLine();
            commands = ParseCommand(command);
            if (commands.Length <= 0)
                continue;
            string cmd = commands[0].ToLower();
            if (cmd == "exit")
                break;
            if (methods.ContainsKey(cmd))
            {
                if (methods[cmd](commands) == 0)
                {
                    PrintInitalPromt();
                }                                                               
            }
            else
            {
                Console.WriteLine($"{commands[0]} command not found");
            }
        }
        Console.WriteLine("\n\tBYE ;)\n");
    }
    private static void PrintPrompt()
    {
        string prompt = "santiago1623@Inventory-CONSOLE~$>>";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"\x1b[1m{prompt}\x1b[0m ");
        Console.ResetColor();
    }

    private static void PrintInitalPromt()
    {
        StringBuilder message = new StringBuilder();
        // message.Append("\nInventory Manager\n");
        // message.Append("-------------------------\n");
        // message.Append("<ClassNames> show all ClassNames of objects\n");
        // message.Append("<All> show all objects\n");
        // message.Append("<All [ClassName]> show all objects of a ClassName\n");
        // message.Append("<Create [ClassName]> a new object\n");
        // message.Append("<Show [ClassName object_id]> an object\n");
        // message.Append("<Update [ClassName object_id]> an object\n");
        // message.Append("<Delete [ClassName object_id]> an object\n");
        // message.Append("<Exit>");
        message.Append("\n\x1b[1m");
        message.Append("=================================================\n");
        message.Append("\t\tInventory Manager\n");
        message.Append("=================================================\n");
        message.Append("\x1b[0m");
        message.Append("\x1b[1m<ClassNames>\x1b[0m show all ClassNames of objects\n");
        message.Append("\x1b[1m<All>\x1b[0m show all objects\n");
        message.Append("\x1b[1m<All [ClassName]>\x1b[0m show all objects of a ClassName\n");
        message.Append("\x1b[1m<Create [ClassName]>\x1b[0m create a new object\n");
        message.Append("\x1b[1m<Show [ClassName object_id]>\x1b[0m show an object\n");
        message.Append("\x1b[1m<Update [ClassName object_id]>\x1b[0m update an object\n");
        message.Append("\x1b[1m<Delete [ClassName object_id]>\x1b[0m delete an object\n");
        message.Append("\x1b[1m<Exit>\x1b[0m exit");
        // message.Append("\n\x1b[1m");
        // message.Append("=================================================");
        // message.Append("\x1b[0m");
        Console.WriteLine(message);
    }

    private static string[] ParseCommand(string command)
    {
        string[] output;
        command = command.Trim();
        output = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return output;
    }

    private static void Initialize()
    {
        methods = new Dictionary<string, method>()
        {
            {"classnames", ClassNames},
            {"all", All},
            {"create", Create},
            {"show", Show},
            {"update", Update},
            {"delete", Delete}
        };

        classes = new Dictionary<string, string>()
        {
            {"baseclass", "BaseClass"},
            {"item", "Item"},
            {"user", "User"},
            {"inventory", "Inventory"}
        };
    }

    private static int UpdateConsole(ref BaseClass obj)
    {
        PropertyInfo[] objProps = obj.GetType().GetProperties();
        if (objProps.Length > 0 && obj.GetType() != typeof(BaseClass))
        {
            Console.WriteLine($"\n\t\x1b[1mType the value for each property, empty entries will be skipped\x1b[0m\n");
        }
        for (int i = 0; i < objProps.Length;)
        {
           
            PropertyInfo property = objProps[i];
            string propName = objProps[i].Name;
            if (propName == "id" || propName == "date_created" || propName == "date_updated")
            {
                i++;
                continue;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            string propRequestStr = $"\x1b[1m\"{propName}\" ({property.PropertyType.Name}) >>\x1b[0m ";
            Console.Write(propRequestStr);
            Console.ResetColor();
            string propValue = Console.ReadLine();
            Console.SetCursorPosition(propRequestStr.Length + propValue.Length -7, --Console.CursorTop);
            propValue = propValue.Trim();
            if (propValue.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\x1b[1m(skipped)\x1b[0m");
                Console.ResetColor();
                i++;
                continue;
            }
            Type propType = property.PropertyType;
            MethodInfo deserailizeMethod = jsonStorage.GetType().GetMethod("DynamicDeserialize").MakeGenericMethod(propType);
            try
            {
                if (propType == typeof(string))
                {
                    if (!propValue.StartsWith("\"") && !propValue.EndsWith("\""))
                    {
                        propValue = $"\"{propValue}\"";
                    }
                }
                Object propValueObj = deserailizeMethod.Invoke(null, new object[] { propValue });
                property.SetValue(obj, propValueObj);                
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\x1b[1m(wrong type try again)\x1b[0m");
                Console.ResetColor();
                continue;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\x1b[1m(set)\x1b[0m");
            Console.ResetColor();
            i++;
        }
        Console.WriteLine();
        return (0);
    }

    private static int ClassNames(string[] input)
    {
        HashSet<string> classNames = new HashSet<string>();
        foreach (string key in jsonStorage.All().Keys)
        {
            string name = key.Split(".")[0];
            classNames.Add(name);
        }
        Console.WriteLine($"[\n  {String.Join(",\n  ", classNames)}\n]");
        return 0;
    }

    private static int All(string[] input)
    {
        // List<string> objectsStr = new List<string>();
        string all;
        if (input.Length == 1)
        {
            // foreach (var obj in jsonStorage.All().Values)
            // {
            //     objectsStr.Add(obj.ToString());
            // }
            // Console.WriteLine($"[\n\t{String.Join(", \n", objectsStr)}\n]");
            all = "[\n";
            foreach (var obj in jsonStorage.All().Values)
            {
                all += $"  {String.Join("\n  ", obj.ToString().Split('\n'))},\n";
            }
            if (all.EndsWith(",\n"))
                all = all.Remove(all.Length - 2);
            all += "\n]";
            Console.WriteLine(all);
            return 0;
        }
        string className = input[1].ToLower();
        if (!classes.ContainsKey(className))
        {
            Console.WriteLine($"{input[1]} is not a valid object type");
            return (1);
        }            
        // foreach (var obj in jsonStorage.All())
        // {
        //     if (obj.Key.Split(".")[0] == classes[className])
        //     {
        //         objectsStr.Add(obj.Value.ToString());
        //     }
        // }
        // Console.WriteLine($"[{String.Join(", ", objectsStr)}]");
        all = "[\n"; 
        foreach (var obj in jsonStorage.All())
        {
            if (obj.Key.Split(".")[0] == classes[className])
            {
                all += $"  {String.Join("\n  ", obj.Value.ToString().Split('\n'))},\n";
            }
        }
        if (all.EndsWith(",\n"))
            all = all.Remove(all.Length - 2);
        all += "\n]";
        Console.WriteLine(all);
        return 0;
    }

    private static int Create(string[] input)
    {
        if (input.Length == 1)
        {
            Console.WriteLine("class name missing");
            return (1);
        }            
        string className = input[1].ToLower();
        if (!classes.ContainsKey(className))
        {
            Console.WriteLine($"{input[1]} is not a valid object type");
            return (1);
        }
        Type type = Type.GetType($"{classes[className]}, InventoryLibrary");
        // if (type == null)
        //     return (1);
        BaseClass new_obj = (BaseClass)Activator.CreateInstance(type);
        UpdateConsole(ref new_obj);
        Console.WriteLine(new_obj.ToString());
        jsonStorage.New(new_obj);
        jsonStorage.Save();
        return 0;
    }

    private static int Show(string[] input)
    {
        if (input.Length == 1)
        {
            Console.WriteLine("class name missing");
            return (1);
        }
        string className = input[1].ToLower();
        if (!classes.ContainsKey(className))
        {
            Console.WriteLine($"{input[1]} is not a valid object type");
            return (1);
        }
        if (input.Length == 2)
        {
            Console.WriteLine("instance id missing");
            return (1);
        }
        string id = $"{classes[className]}.{input[2]}";
        if (!jsonStorage.All().ContainsKey(id))
        {
            Console.WriteLine($"Object {input[2]} could not be found");
            return (1);
        }
        Console.WriteLine(jsonStorage.All()[id].ToString());
        return (0);
    }

    private static int Update(string[] input)
    {
        if (input.Length == 1)
        {
            Console.WriteLine("class name missing");
            return (1);
        }
        string className = input[1].ToLower();
        if (!classes.ContainsKey(className))
        {
            Console.WriteLine($"{input[1]} is not a valid object type");
            return (1);
        }
        if (input.Length == 2)
        {
            Console.WriteLine("instance id missing");
            return (1);
        }
        string id = $"{classes[className]}.{input[2]}";
        if (!jsonStorage.All().ContainsKey(id))
        {
            Console.WriteLine($"Object {input[2]} could not be found");
            return (1);
        }
        BaseClass obj = jsonStorage.All()[id];
        UpdateConsole(ref obj);
        obj.date_updated = DateTime.Now;
        jsonStorage.Save();
        Console.WriteLine(obj.ToString());
        return (0);
    }

    private static int Delete(string[] input)
    {
        if (input.Length == 1)
        {
            Console.WriteLine("class name missing");
            return (1);
        }
        string className = input[1].ToLower();
        if (!classes.ContainsKey(className))
        {
            Console.WriteLine($"{input[1]} is not a valid object type");
            return (1);
        }
        if (input.Length == 2)
        {
            Console.WriteLine("instance id missing");
            return (1);
        }
        string id = $"{classes[className]}.{input[2]}";
        if (!jsonStorage.All().ContainsKey(id))
        {
            Console.WriteLine($"Object {input[2]} could not be found");
            return (1);
        }
        Console.Write("\x1b[1mare you sure? (Y:yes !Y:no) >>\x1b[0m ");
        string confirmation = Console.ReadLine();
        if (confirmation.Trim().ToLower() != "y" && confirmation.Trim().ToLower() != "yes")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\x1b[1mdelete canceled\x1b[0m");
            Console.ResetColor();
            return (0);
        }
        if (jsonStorage.All().Remove(id))
        {
            jsonStorage.Save();
            Console.WriteLine($"{id} removed succesfully");
            return (0);
        }
        else
        {
            Console.WriteLine($"a problem occurr while removing {id} try again");
            return (1);
        }
    }
}
