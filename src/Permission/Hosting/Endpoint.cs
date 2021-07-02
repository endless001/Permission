using System;
using Microsoft.AspNetCore.Http;

namespace Permission.Hosting
{
    public class Endpoint
    {
        public Endpoint(string name, string path, Type handlerType)
        {
            Name = name;
            Path = path;
            Handler = handlerType;
        }

        public string Name { get; set; }
        public PathString Path { get; set; }
        public Type Handler { get; set; }
    }
}
