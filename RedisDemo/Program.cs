using RedisDemo;

var redis = new RedisService();

// Save data
await redis.SetAsync("name", "Deepanshu 🔥");

// Get data
var value = await redis.GetAsync("name");

Console.WriteLine(value);

Console.ReadLine(); // add this