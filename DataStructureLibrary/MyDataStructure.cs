using System.Collections;

namespace DataStructureLibrary
{
	public class MyDataStructure : IMyDataStructure, IEnumerable<short>
	{
		private MyDataStructureNode? _root;

		public MyDataStructureNode? Root => _root;

		public MyDataStructure()
		{
			_root = null;
		}

		public MyDataStructure(MyDataStructureNode root)
		{
			_root = root;
		}

		public void Add(short value)
		{
			if (_root == null)
			{
				_root = new MyDataStructureNode();
				_root.Value = value;
				_root.Next = null;
			}
			else
			{
				MyDataStructureNode node = new MyDataStructureNode();
				node.Value = value;
				node.Next = _root;
				_root = node;
			}
		}

		public void Remove(short value)
		{
			if (_root == null)
			{
				return;
			}
			else if (_root.Next == null)
			{
				if (_root.Value == value)
				{
					_root = null;
				}
				return;
			}

			MyDataStructureNode? node = _root;

			do
			{
				if (node.Value == value)
				{
					node.Value = node.Next.Value;
					node.Next = node.Next.Next;
					return;
				}
				else if (node.Next != null && node.Next.Next == null && node.Next.Value == value)
				{
					node.Next = null;
				}
				else
				{
					node = node.Next;
				}
			}
			while (node != null);
		}

		public MyDataStructureNode? FindFirstMultipleOfThree()
		{
			if (_root == null)
			{
				return null;
			}

			MyDataStructureNode? node = _root;
			do
			{
				if (node.Value % 3 == 0)
				{
					return node;
				}

				node = node.Next;
			} while (node != null);

			return null;
		}

		public long GetProductOfNumbersLessThanAverage()
		{
			if (_root == null || _root.Next == null)
			{
				return 0;
			}

			MyDataStructureNode? node = _root;
			int sum = 0;
			int count = 0;

			do
			{
				sum += node.Value;
				count++;

				node = node.Next;
			} while (node != null);

			double average = (double)sum / count;
			node = _root;
			long product = 1;

			do
			{
				if (node.Value < average)
				{
					product *= node.Value;
				}

				node = node.Next;
			} while (node != null);

			return product;
		}

		public MyDataStructure GetNewStructureOfMultipleOfThree()
		{
			if (_root == null)
			{
				return new MyDataStructure();
			}

			MyDataStructure newDataStructure = new MyDataStructure(_root);
			MyDataStructureNode? node = _root;

			do
			{
				if (node.Value % 3 != 0)
				{
					newDataStructure.Remove(node.Value);

					if (node.Next == null)
					{
						break;
					}
				}
				else
				{
					node = node.Next;
				}
			} while (node != null && newDataStructure.Root != null);

			return newDataStructure;
		}

		public void RemoveBiggerThanAverage()
		{
			if (_root == null || _root.Next == null)
			{
				return;
			}

			MyDataStructureNode? node = _root;
			int sum = 0;
			int count = 0;

			do
			{
				sum += node.Value;
				count++;

				node = node.Next;
			} while (node != null);

			double average = (double)sum / count;
			node = _root;

			do
			{
				if (node.Value > average)
				{
					this.Remove(node.Value);
				}
				else
				{
					node = node.Next;
				}
			} while (node != null);
		}

		public IEnumerator<short> GetEnumerator()
		{
			MyDataStructureNode? node = _root;

			while (node != null)
			{
				yield return node.Value;
				node = node.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public class MyDataStructureNode : IMyDataStructureNode
	{
		private short _value;
		private MyDataStructureNode? _next;

		public short Value
		{
			get => _value;
			set => _value = value;
		}
		public MyDataStructureNode? Next
		{
			get => _next;
			set => _next = value;
		}
	}
}