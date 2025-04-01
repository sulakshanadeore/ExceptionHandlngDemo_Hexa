using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibraryForExceptionHandling
{

	//Exception snippet(exception Press tab twice)
	[Serializable]
	public class StudentNotFoundException : Exception
	{
		public StudentNotFoundException() { }
		public StudentNotFoundException(string message) : base(message) { }
		public StudentNotFoundException(string message, Exception inner) : base(message, inner) { }
		protected StudentNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
