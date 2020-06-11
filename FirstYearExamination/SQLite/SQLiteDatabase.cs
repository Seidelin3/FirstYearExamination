﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using FirstYearExamination.SQLiteFrameWork;
using FirstYearExamination.SQLiteFrameWork.Models;
using FirstYearExamination.SQLiteFrameWork.Factories;

namespace FirstYearExamination.SQLite
{
	/// <summary>
	/// Lavet af Marius Rysgaard
	/// </summary>
	public class SQLiteDatabase
	{
		public void RunSQLite()
		{
			Database();
		}

		private void Database()
		{
			AutoTable<Gold> autoTable = new AutoTable<Gold>();
			autoTable.MakeTable();

			Gold_Factory gold_Factory = new Gold_Factory();

			Gold gold = gold_Factory.Get(1);
		}
	}
}
