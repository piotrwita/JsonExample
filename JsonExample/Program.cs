// See https://aka.ms/new-console-template for more information
using JsonExample;
using System.Text.Json;

//serializacja
Post post = new Post("Tytuł", "Treść");
string jsonString = JsonSerializer.Serialize(post);

//deserializacja
Post deserializePost = JsonSerializer.Deserialize<Post>(jsonString);
