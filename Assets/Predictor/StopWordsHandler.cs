using System;
using System.Collections;
	/// <summary>
	/// Stop words are frequently occurring, insignificant words words 
	/// that appear in a database record, article or web page. 
	/// Common stop words include
	/// </summary>
	public class StopWordsHandler
	{		
		public static string[] stopWordsList=new string[] {

															  "a"
		} ;

		private static Hashtable _stopwords=null;

		public static object AddElement(IDictionary collection,Object key, object newValue)
		{
			object element = collection[key];
			collection[key] = newValue;
			return element;
		}

		public static bool IsStopword(string str)
		{
			if (_stopwords == null)
			{
				_stopwords = new Hashtable();
				double dummy = 0;
				foreach (string word in stopWordsList)
				{
					AddElement(_stopwords, word, dummy);
				}
			}

			return _stopwords.ContainsKey(str.ToLower());
		}
	

		public StopWordsHandler()
		{
			if (_stopwords == null)
			{
				_stopwords = new Hashtable();
				double dummy = 0;
				foreach (string word in stopWordsList)
				{
					AddElement(_stopwords, word, dummy);
				}
			}
		}
	}

