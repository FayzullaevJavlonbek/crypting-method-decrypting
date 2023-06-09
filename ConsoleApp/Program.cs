﻿
using Baseline.Reflection;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Security;
using ConsoleApp.Services;
using ImTools;
using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

class Program
{
    public static void Main()
    {
        
        string path = "D:/user.json";
        List<User> users = new List<User>()
        {
            new User()
            {
                Name = "Ali",
                Email = "Email"
            },
            new User()
            {
                Name = "Javlonbek",
                Email = "Email"
            },
            new User()
            {
                Name = "Abdurohman",
                Email = "Email"
            }
        };

        var json = JsonConvert.SerializeObject(users);
        File.WriteAllText(path, json);

        var read = File.ReadAllText(path);
        var reader = JsonConvert.DeserializeObject<List<User>>(read);
        foreach(var item in reader)
        {
            Console.WriteLine(item.Name );
        }
    }
   
}