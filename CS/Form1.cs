using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ShowEditorOnEnter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn colColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn colColumn3;
		internal DevExpress.XtraEditors.TextEdit TextEdit1;
		internal System.Data.DataSet DataSet1;
		internal System.Data.DataTable DataTable1;
		internal System.Data.DataColumn DataColumn1;
		internal System.Data.DataColumn DataColumn2;
		internal System.Data.DataColumn DataColumn3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TextEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.DataSet1 = new System.Data.DataSet();
			this.DataTable1 = new System.Data.DataTable();
			this.DataColumn1 = new System.Data.DataColumn();
			this.DataColumn2 = new System.Data.DataColumn();
			this.DataColumn3 = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
			this.SuspendLayout();
			// 
			// GridControl1
			// 
			this.GridControl1.DataSource = this.DataTable1;
			// 
			// GridControl1.EmbeddedNavigator
			// 
			this.GridControl1.EmbeddedNavigator.Name = "";
			this.GridControl1.Location = new System.Drawing.Point(8, 40);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.TabIndex = 3;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.GridView1});
			this.GridControl1.Enter += new System.EventHandler(this.GridControl1_Enter);
			// 
			// GridView1
			// 
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.colColumn1,
																							 this.colColumn2,
																							 this.colColumn3});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			// 
			// colColumn1
			// 
			this.colColumn1.Caption = "Column1";
			this.colColumn1.FieldName = "Column1";
			this.colColumn1.Name = "colColumn1";
			this.colColumn1.Visible = true;
			this.colColumn1.VisibleIndex = 0;
			// 
			// colColumn2
			// 
			this.colColumn2.Caption = "Column2";
			this.colColumn2.FieldName = "Column2";
			this.colColumn2.Name = "colColumn2";
			this.colColumn2.Visible = true;
			this.colColumn2.VisibleIndex = 1;
			// 
			// colColumn3
			// 
			this.colColumn3.Caption = "Column3";
			this.colColumn3.FieldName = "Column3";
			this.colColumn3.Name = "colColumn3";
			this.colColumn3.Visible = true;
			this.colColumn3.VisibleIndex = 2;
			// 
			// TextEdit1
			// 
			this.TextEdit1.EditValue = "Press Tab to focus the grid and start editing";
			this.TextEdit1.Location = new System.Drawing.Point(8, 8);
			this.TextEdit1.Name = "TextEdit1";
			// 
			// TextEdit1.Properties
			// 
			this.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.TextEdit1.Size = new System.Drawing.Size(400, 20);
			this.TextEdit1.TabIndex = 2;
			// 
			// DataSet1
			// 
			this.DataSet1.DataSetName = "NewDataSet";
			this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
																		  this.DataTable1});
			// 
			// DataTable1
			// 
			this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
																			  this.DataColumn1,
																			  this.DataColumn2,
																			  this.DataColumn3});
			this.DataTable1.TableName = "Table1";
			// 
			// DataColumn1
			// 
			this.DataColumn1.ColumnName = "Column1";
			// 
			// DataColumn2
			// 
			this.DataColumn2.ColumnName = "Column2";
			// 
			// DataColumn3
			// 
			this.DataColumn3.ColumnName = "Column3";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 250);
			this.Controls.Add(this.GridControl1);
			this.Controls.Add(this.TextEdit1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void GridControl1_Enter(object sender, System.EventArgs e) {
			GridControl grid = sender as GridControl; 
			GridView view = grid.MainView as GridView;

			if(view.DataRowCount == 0) {
				if(view.FocusedRowHandle == GridControl.InvalidRowHandle)
					view.FocusedRowHandle = GridControl.NewItemRowHandle;
                BeginInvoke(new MethodInvoker(delegate { view.ShowEditor(); }));
			}
		}
	}
}
