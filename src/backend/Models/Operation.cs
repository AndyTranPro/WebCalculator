using System;
using System.Text.Json.Serialization;

namespace backend.Models;

public class Operation
{
    [JsonPropertyName("@ID")]
    public string ID { get; set; }
    public List<int> Value { get; set; }
}
