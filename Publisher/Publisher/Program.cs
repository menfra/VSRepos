using Publisher.DataModels;
using Publisher.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Publisher
{
    class Program
    {
        private readonly static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                // Create a user object
                User user = new User()
                {
                    Name = $"Publisher_{RandomString(8)}",
                    DisplayName = "Publisher",
                    Age = DateTime.Now.Second.ToString(),
                    Occupation = "Producer"
                };

                // Save the object to a db
                //var savedUser = await DataServices.GetInstance.AddData("", user);

                // send the object to a message queue for the other service to also use.
                if (user != null)
                    QueueServices.GetInstance.Produce(user);

                //await Task.Delay(1000);
                Console.ReadLine();
            }
           
        }

        /// <summary>
        /// Generates a random string
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
