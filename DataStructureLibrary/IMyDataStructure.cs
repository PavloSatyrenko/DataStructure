using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLibrary
{
	internal interface IMyDataStructure
	{
		MyDataStructureNode? Root { get; }

		void Add(short value);
		void Remove(short value);
		MyDataStructureNode? FindFirstMultipleOfThree();
		long GetProductOfNumbersLessThanAverage();
		MyDataStructure GetNewStructureOfMultipleOfThree();
		void RemoveBiggerThanAverage();
	}

	internal interface IMyDataStructureNode
	{
		short Value { get; set; }
		MyDataStructureNode? Next { get; set; }
	}
}
