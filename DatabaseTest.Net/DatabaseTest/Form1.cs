using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseTest.Data.SqlServer.Repositories;

namespace DatabaseTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShowCategories_Click( object sender, EventArgs e )
		{
			ArticleRepository repository = new ArticleRepository();
			List<string> categoryNames = repository.GetCategoryNames();

			this.lstCategories.Items.AddRange(categoryNames.ToArray<object>());
		}
	}
}
