﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
namespace RecNote.Entities.Audios
{
	using RecNote.Entities;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Audio : Base
	{
		public virtual string ProjectID
		{
			get;
			set;
		}

		public virtual string FileID
		{
			get;
			set;
		}

		public virtual string Name
		{
			get;
			set;
		}

		public virtual DateTime Date
		{
			get;
			set;
		}

		public Audio()
		{
		}

	}
}

