namespace LongestCommonPrefix
{
	internal class CommonPrefixLongest
	{
		private class TrieNode
		{
			public bool isWord;
			public readonly TrieNode[] children;

			public TrieNode()
			{
				children = new TrieNode[26];
			}
		}

		private class Trie
		{
			private TrieNode root;

			public Trie()
			{
				root = new();
			}

			public void Add(string str)
			{
				TrieNode node = root;
				foreach (char ch in str)
				{
					if (node.children[ch - 'a'] is null)
					{
						node.children[ch - 'a'] = new TrieNode();
					}
					node = node.children[ch - 'a'];
				}
				node.isWord = true;
			}

			public int GetCommonPrefix(string str)
			{
				TrieNode node = root;
				for (int i = 0; i < str.Length; ++i)
				{
					if (node.children[str[i] - 'a'] is null)
					{
						return i;
					}
					node = node.children[str[i] - 'a'];
				}
				return str.Length;
			}
		}

		public string LongestCommonPrefix(string[] strs)
		{
			int n = strs.Length;
			int smallestIndex = 0;
			for (int i = 0; i < n; ++i)
			{
				if (strs[i].Length < strs[smallestIndex].Length)
				{
					smallestIndex = i;
				}
			}
			Trie trie = new();
			trie.Add(strs[smallestIndex]);
			int maxLength = int.MaxValue;
			for (int i = 0; i < n; ++i)
			{
				if (i == smallestIndex)
				{
					maxLength = Math.Min(maxLength, strs[i].Length + 1);
				}
				maxLength = Math.Min(maxLength, trie.GetCommonPrefix(strs[i]) + 1);
			}
			return maxLength == 0 ? string.Empty : strs[smallestIndex][..(maxLength - 1)];
		}
	}
}
