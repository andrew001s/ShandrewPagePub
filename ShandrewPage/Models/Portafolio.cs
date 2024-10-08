﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShandrewPage.Models
{
    public class Portafolio
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? nombre { get; set; }
        public string? Tipo { get; set; }
        public byte[]? imagen { get; set; }

        public string? ruta { get; set;}
    }
}
