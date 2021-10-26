﻿namespace FamilyWepApi.Models
{
    public class Interest
    {
        public string Type { get; set; }
        public string Description { get; set; }
        
        public override string ToString()
        {
            return $"{Type} {Description}";
        }
    }
}