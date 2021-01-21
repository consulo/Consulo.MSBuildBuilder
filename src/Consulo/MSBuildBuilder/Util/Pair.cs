namespace Consulo.MSBuildBuilder.Util
{
	/// <summary>
	/// Analog ValueTuple - just do not need add dependency
	/// </summary>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	public struct Pair<T1, T2>
	{
		public static Pair<K1, K2> Of<K1, K2>(K1 k1, K2 k2)
		{
			return new Pair<K1, K2>(k1, k2);
		}

		public T1 Item1;
		public T2 Item2;

		public Pair(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}
	}
}
