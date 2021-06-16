using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public enum RepairStatus : ushort
{
	[Description("Nowe")]
	New = 0,
	[Description("W trakcie")]
	InProgrres = 1,
	[Description("Gotowe do wydania")]
	Ready = 2,
	[Description("Zakończone")]
	Finished = 3
}


public static class EnumList
{
	public static IEnumerable<KeyValuePair<T, string>> Of<T>()
	{
		return Enum.GetValues(typeof(T))
			.Cast<T>()
			.Select(p => new KeyValuePair<T, string>(
				p,
				(p.GetType().GetField(p.ToString())
				.GetCustomAttributes(typeof(DescriptionAttribute), false)
				.FirstOrDefault() as DescriptionAttribute)?.Description ?? p.ToString()
				))
				.ToList();
	}

	public static string GetEnumDescription(this Enum value)
	{
		System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());

		DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

		if (attributes != null && attributes.Length > 0)
			return attributes[0].Description;
		else
			return value.ToString();
	}
}