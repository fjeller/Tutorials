using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTest.Data.SqlServer.DataAccess;

namespace DatabaseTest.Data.SqlServer.Repositories
{
	public class ArticleRepository
	{

		public List<string> GetCategoryNames()
		{

			ArticleDataContext dataContext = new ArticleDataContext();
			dataContext.Database.Log = (item) =>
			{
				if (!File.Exists("commands.txt"))
				{
					File.WriteAllText("commands.txt", $"Created {DateTime.Now}");
				}

				File.AppendAllText("commands.txt", item);
				File.AppendAllText("commands.txt", "\r\n\r\n----------------------------------------------------------------------------------\r\n\r\n");
			};

			var result = dataContext.Categories
				.Include(c => c.Articles)
				.OrderBy(c => c.Name)
				.Select(c => c.Name)
				.ToList();

			return result;
		}

	}
}
