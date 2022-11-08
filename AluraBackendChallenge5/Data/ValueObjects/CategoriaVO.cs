using AluraBackendChallenge5.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AluraBackendChallenge5.Data.ValueObjects
{
    public class CategoriaVO
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Cor { get; set; }

        [JsonIgnore]
        public ICollection<VideoVO>? Videos { get; set; }
    }
}
