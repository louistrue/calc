﻿using Speckle.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Core.Objects
{
    public class Forest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("forest_name")]
        public string Name { get; set; }
        [JsonProperty("trees")] // for recieving the tree JSON from the API
        public List<Tree> Trees { get; set; }
        [JsonProperty("project_id")]
        public Project Project { get; set; }

        public string SerializeTrees()
        {
            var treesJson = new StringBuilder();
            treesJson.Append($"[{string.Join(",", Trees.Select(t => t.Serialize()))}]");
            return treesJson.ToString();
        }
    }
}