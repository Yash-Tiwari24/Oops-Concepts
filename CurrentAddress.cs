using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    public class CurrentAddress
    {
        private IStudentQueue _studentQueue;
        private static IStudentQueue s_studentQueue;

        [ThreadStatic]
        private static TimeSpan t_timeSpan;

        public void SomeMethod<T>(int someNumber, bool isValid)
        {
        }

    }

    public class StudentEvents
    {
        // A public field, these should be used sparingly
        public bool IsValid;

        // An init-only property
        public IStudentQueue StudentQueue { get; init; }

        // An event
        public event Action EventProcessing;

        // Method
        public void StartEventProcessing()
        {
            // Local function
            static int CountQueueItems()=>40 ;
            // ...
        }
    }

    public record PermanentAddress(
    string Street,
    string City,
    string StateOrProvince,
    string ZipCode);

    public struct StudentInformation
    {
    }

    public interface IStudentQueue
    {
    }
}
