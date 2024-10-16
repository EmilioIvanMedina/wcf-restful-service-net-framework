using System.Runtime.Serialization;

namespace WcfRestfulService.DataContracts
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Genre { get; set; }
    }
}