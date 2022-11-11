using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace PruebaTecnica.Models
{
  
    [System.Serializable]
    public class DataItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool hasChildren { get; set; }
        public string url { get; set; }
        public List<Child> children { get; set; }
        public string Title { get; set; }
        public string MetaTagDescription { get; set; }
    }

    public class Child
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool hasChildren { get; set; }
        public string url { get; set; }
        public List<object> children { get; set; }
        public string Title { get; set; }
        public string MetaTagDescription { get; set; }
    }



}