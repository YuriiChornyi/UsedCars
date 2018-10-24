namespace UsedCars.Helpers
{
	/// <summary>
	/// SaveUpdateResultModel
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public struct SaveUpdateResultModel<T>
	{
		/// <summary>
		/// Gets or sets the result.
		/// </summary>
		public T Result { get; set; }

		/// <summary>
		/// Gets or sets the error code.
		/// </summary>
		public ErrorCode ErrorCode { get; set; }
	}
}
