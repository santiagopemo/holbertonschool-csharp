using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Reflection;


/// <summary>
///  Class JSONStorage
/// </summary>
public class JSONStorage<T> where T : BaseClass
{
    // storage filename
    private const string FILENAME = @"inventory_manager.json";
    // storage directory
    private const string DIRECTORY = @"storage/";
    // storage path
    private string _path = $"{DIRECTORY}{FILENAME}";

    /// <summary>
    ///  property object of type dictionary of strings and objects
    /// </summary>
    public Dictionary<string, T> objects {get; set;} = new Dictionary<string, T>();
    /// <summary>
    ///  JSONStorage constructor
    /// </summary>
    public JSONStorage()
    {
        string[] cwdPath = Directory.GetCurrentDirectory().Split('/');
        string cwd = cwdPath[cwdPath.Length - 1];
        if (cwd == "InventoryManager")
        {
            _path = $"../{_path}";
            if (!Directory.Exists($"../{DIRECTORY}"))
            {
                Directory.CreateDirectory($"../{DIRECTORY}");
            }
        }
        else
        {
            if (!Directory.Exists(DIRECTORY))
            {
                Directory.CreateDirectory(DIRECTORY);
            }
        }
    }
    /// <summary>
    ///  returns objects dictionary
    /// </summary>
    public Dictionary<string, T> All()
    {
        return objects;
    }
    /// <summary>
    ///  Add a new key-value pair to objects
    /// </summary>
    public void New(T obj)
    {
        objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
    }
    /// <summary>
    ///  serializes objects to JSON and saves to hte JSON file
    /// </summary>
    public void Save()
    {
        try
        {
            using (StreamWriter sw = File.CreateText(_path))
            {
                // string json_string = JsonSerializer.Serialize<Dictionary<string, Object>>(objects);
                string json_string = "{";
                foreach (var obj in objects)
                {
                    json_string += $"{JsonSerializer.Serialize<string>(obj.Key)}:";
                    json_string += $"{JsonSerializer.Serialize<Object>(obj.Value)},";
                }
                if (json_string.EndsWith(","))
                    json_string = json_string.TrimEnd(',');
                json_string += "}";
                sw.WriteLine(json_string);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("An error occur while creating the file");
        }            
    }
    /// <summary>
    ///  deserializes objects to JSON and saves to hte JSON file
    /// </summary>
    public void Load()
    {
        if (File.Exists(_path))
        {
            using (StreamReader sr = File.OpenText(_path))
            {
                string json_string = sr.ReadLine();
                Dictionary<string, Object> obj_dict = new Dictionary<string, object>();
                obj_dict = JsonSerializer.Deserialize<Dictionary<string, Object>>(json_string);
                foreach (var obj in obj_dict)
                {
                    string obj_type = obj.Key.Split('.')[0];
                    Type type = Type.GetType($"{obj_type}");
                    if (type == null)
                        continue;
                    MethodInfo deserailizeMethod = this.GetType().GetMethod("DynamicDeserialize").MakeGenericMethod(type);
                    Object new_obj = deserailizeMethod.Invoke(null, new object[] { obj.Value });
                    New((T)new_obj);
                }
            }
        }
        else
        {
            // Console.WriteLine($"{_path} doesn´t exist");
        }                
    }
    /// <summary>
    ///  deserializes a object, based on a given type
    /// </summary>
    public static TClass DynamicDeserialize<TClass>(Object o)
    {
        return (TClass)JsonSerializer.Deserialize<TClass>(o.ToString());
    }
}
