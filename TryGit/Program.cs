using System.Reflection.Metadata.Ecma335;

namespace TryGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseMessage baseMessage = new BaseMessage();
            
            Console.WriteLine(baseMessage.CorrelationId().ToString());

        }
    }

    public class BaseMessage
    {
        /// <summary>
        /// Unique Identifier used by logging
        /// </summary>
        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}