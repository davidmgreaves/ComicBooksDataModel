﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBooksDataModel
{
	public class Title
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual Company Company { get; set; }
	}
}
