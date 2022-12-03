using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Encryptor
{
    static class FileController
    {
        private static string path = "Users.json";

        public static void WriteInfo(List<User> list) => File.WriteAllText(path, JsonSerializer.Serialize(list));
        public static UserList ReadInfo()
        {
            UserList temp = new UserList();
            if (File.Exists(path))
            {
                string tempUsers = File.ReadAllText(path);
                temp.Users = JsonSerializer.Deserialize<List<User>>(tempUsers);
            }
            return temp;
        }
    }
}
