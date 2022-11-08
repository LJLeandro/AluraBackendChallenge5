using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AluraBackendChallenge5.Data.ValueObjects
{
    public class VideoVO
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string URL { get; set; }

        public int? CategoriaId { get; set; }

        [JsonIgnore]
        public CategoriaVO? CategoriaVO { get; set; }
    }
}
