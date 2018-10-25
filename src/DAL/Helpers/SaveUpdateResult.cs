namespace DAL.Helpers
{
	public struct SaveUpdateResult<T>
	{
		/// <summary>
		/// Gets or sets the result.
		/// </summary>
		public T Result { get; set; }

		/// <summary>
		/// Gets or sets the error code.
		/// </summary>
		public ErrorCodeExtended ErrorCode { get; set; }
	}
}
