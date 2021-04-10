using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lyrics
{
    [Serializable()]
    public class Lyrics : ISerializable
    {
        public string Name  { get; set; }
        public string Title { get; set; }
        public string Texte { get; set; }

        public Lyrics() { }
        public Lyrics(string name, string title, string texte)
        {
            this.Name = name;
            this.Title = title;
            this.Texte = texte;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Title", Title);
            info.AddValue("Texte", Texte);
        }

        public Lyrics(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name  = (string)info.GetValue("Name",  typeof(string));
            Title = (string)info.GetValue("Title", typeof(string));
            Texte = (string)info.GetValue("Texte", typeof(string));
        }
    }
}
