using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisDemo
{
    public class RedisService
    {
        private readonly IDatabase _db;

        public RedisService()
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            _db = redis.GetDatabase();
        }

        public async Task SetAsync(string key, string value)
        {
            await _db.StringSetAsync(key, value);
        }

        public async Task<string> GetAsync(string key)
        {
            return await _db.StringGetAsync(key);
        }
    }
}
